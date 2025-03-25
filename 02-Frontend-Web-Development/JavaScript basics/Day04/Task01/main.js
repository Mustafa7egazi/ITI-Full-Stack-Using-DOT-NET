function showResult(){
    var tagNameInput = document.getElementById("tagName");
    var classNameInput = document.getElementById("className");
    var IdInput = document.getElementById("Id");
    var NameInput = document.getElementById("Name");

    var outText = "";
    outText += "<br>";
    if(tagNameInput.value != ""){
        outText += `# of ${tagNameInput.value} is `+ 
        document.getElementsByTagName(tagNameInput.value).length;
    }

    if(classNameInput.value != ""){
        outText += ` | # of ${classNameInput.value} is ` +
        document.getElementsByClassName(classNameInput.value).length;
    }

    if(IdInput.value != ""){
        outText += ` | # of ${IdInput.value} is ` +
    (document.getElementById(IdInput.value) ? 1 : 0);
    }

    if(NameInput.value != ""){
        outText += ` | # of ${NameInput.value} is ` +
        document.getElementsByName(NameInput.value).length;
    }

    if (outText != "") {
        var outElement =document.getElementById("outputContent");
        outElement.firstElementChild.innerHTML = outText;
        outElement.style.display = "block";
    }
   
} 