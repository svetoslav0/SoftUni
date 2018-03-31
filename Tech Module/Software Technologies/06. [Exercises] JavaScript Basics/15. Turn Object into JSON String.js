function solve(input) {
        let obj = {};
        for(let i = 0; i < input.length; i++){
            let arr = input[i].split(" -> ");
            let key = arr[0];
            let value;
            if(key == "age" || key == "grade"){
                value = Number(arr[1]);
            }
            else{
                value = arr[1];
            }
            obj[key] = value;
        }
    let string = JSON.stringify(obj);
    console.log(string);
}

solve(['name -> Angel', 'surname -> Georgiev', 'age -> 20', 'grade -> 6.00', 'date -> 23/05/1995', 'town -> Sofia']);



//{"name":"Angel","surname":"Georgiev","age":20,"grade":6,"date":"19/05/1995","town":"Sofia"}