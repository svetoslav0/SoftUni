function addRemove(arr) {
    let result = [];
    for(let i = 0; i < arr.length; i++){
        let splitted = arr[i].split(" ");
        let command = splitted[0];
        let num = Number(splitted[1]);
        if(command == "add"){
            result.push(num);
        }
        else if(command == "remove"){
            result.splice(num,1);
        }
    }
    for(let i = 0; i < result.length; i++){
        if(result[i] != undefined){
            console.log(result[i]);
        }
    }
}

addRemove(['add 3', 'add 5', 'remove 2', 'remove 0', 'add 7']);