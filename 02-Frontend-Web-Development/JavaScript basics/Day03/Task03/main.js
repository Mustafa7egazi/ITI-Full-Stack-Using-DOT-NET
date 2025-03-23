function secondMinMax(arr) {
    var disticitArr = [];

    var sortedArr = arr.sort((a, b) => a - b);

    for (let index = 0; index < sortedArr.length; index++) {
        if (!disticitArr.includes(sortedArr[index])) {
            disticitArr.push(sortedArr[index]);
        } 
    }
  
    var secondLowest = disticitArr[1];
    var secondGreatest = disticitArr[disticitArr.length - 2];
  
    return ` Second Lowest: ${secondLowest}, Second Highest: ${secondGreatest}`;
  }


  var input = [1,2,3,4,5,1,5];

  console.log(secondMinMax(input));