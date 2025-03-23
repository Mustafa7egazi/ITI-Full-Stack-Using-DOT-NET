function printObjData(person) {
    var data = "";
    for (var key in person) {
        if (typeof person[key] === 'object' && person[key] !== null) {
            data += `${key}:<br>`;
            for (let innerKey in person[key]) {
                data += `${innerKey}: ${person[key][innerKey]}<br>`;
            }
        } else {
            data += `${key}: ${person[key]}<br>`;
        }
    }
    return data;
}



var me = {
    name: "Mustafa Hegazy",
    age: 24,
    grades: {
      math: 90,
      science: 85,
      literature: 88
    },
    contactInfo: {
      email: "7egz@gmail.com",
      phone: "123-456-7890"
    }
  };


  document.writeln(printObjData(me));
  



