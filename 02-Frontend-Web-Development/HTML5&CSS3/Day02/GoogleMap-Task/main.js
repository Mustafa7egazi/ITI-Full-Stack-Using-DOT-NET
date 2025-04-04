var options = document.getElementsByTagName("select")[0];
getThePosition(options.value);

function initMap(myLat,myLng) {
  const myLatLng = { lat: myLat, lng: myLng };
  const map = new google.maps.Map(document.getElementById("map"), {
    zoom: 4,
    center: myLatLng,
  });

  new google.maps.Marker({
    position: myLatLng,
    map,
    title: "Hello World!",
  });
}

function getThePosition(countryName) {
    var request = new XMLHttpRequest();
    request.open("GET",`https://nominatim.openstreetmap.org/search?format=json&q=${countryName}`);
    request.send();
    
    request.onload = function(){
        var lat = Number(JSON.parse(request.response)[0].lat);
        var lng = Number(JSON.parse(request.response)[0].lon);
        initMap(lat,lng);
        console.log(JSON.parse(request.response)[0]);
    }
}
options.addEventListener("change",function(){
   getThePosition(options.value);
});


window.initMap = initMap;
