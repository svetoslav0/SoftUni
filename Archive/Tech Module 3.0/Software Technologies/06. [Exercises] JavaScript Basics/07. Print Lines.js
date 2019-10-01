function solve(arr) {
    let i = 0;
    while(true){
        if(arr[i] != 'Stop'){
            console.log(arr[i]);
        }
        else{
            break;
        }
        i++;
    }
}

solve(['3', '6', '5', '4', 'Stop', '10', '12']);