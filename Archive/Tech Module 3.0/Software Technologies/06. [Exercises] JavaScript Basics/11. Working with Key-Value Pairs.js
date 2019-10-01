function keyValue(arr) {
    let searchedKey = arr[arr.length - 1];
    let dict = {};
    for(let i = 0; i < arr.length - 1; i++){
        let currentArr = arr[i].split(' ');
        let key = currentArr[0];
        let value = currentArr[1];
        dict[key] = value;
    }
    if(dict[searchedKey] == undefined){
        console.log("None");
    }
    else{
        console.log(dict[searchedKey]);
    }
}


keyValue(['3 bla', '3 alb', '2']);