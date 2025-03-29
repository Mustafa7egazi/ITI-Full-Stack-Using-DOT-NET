function acceptingOnlyTwo() {
    try {
        if(arguments.length >2){
            throw new Error("You Must enter 2 values");
        }else{
            alert(`Your args is first:${arguments[0]}, second:${arguments[1]}`);
        }
    } catch (error) {
        alert(`${error.message}`);
    }finally{
        console.log("Nice catch ;)");
    }
}

//acceptingOnlyTwo("Hi",2025); // works fine
//acceptingOnlyTwo("Hi",2025,"Bye"); 

function addingNumbers(){

    var sum=0;
   try{
    if (arguments.length == 0) {
        throw new Error("Pass a numeric value");
       }else{
        for (var index = 0; index < arguments.length; index++) {
            if (isNaN(arguments[index])) {
                throw new Error("Accept only numbers");
            }else{
                sum+=arguments[index];
            }    
        }
       }

       alert(`Total sum: ${sum}`);
   }catch(e){
        alert(e.message);
   }finally{
    console.log("Nice catch ;)");
   }

}

// addingNumbers(5,4);  // works
// addingNumbers(5,"fd");  // not working
// addingNumbers();  // not working
