function setValues(arr) {
    let n = Number(arr[0]);
    let result = [];
    for(let i = 0; i < n; i++){
        result[i] = 0;
    }
    for(let i = 1; i < arr.length; i++){
        let splitted = arr[i].split(" - ");
        let index = splitted[0];
        let value = splitted[1];
        result[index] = value;
    }
    for(let i = 0; i < result.length; i++){
        console.log(result[i]);
    }
}

setValues(
    ['3', '0 - 5', '1 - 6', '2 - 7']
);
setValues(['5', '0 - 3', '3 - -1', '4 - 2']);