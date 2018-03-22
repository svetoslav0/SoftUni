function solve(arr) {
    let n = Number(arr[0]);
    let x = Number(arr[1]);
    if(x >= n){
        console.log(n * x);
    }
    else{
        console.log(n / x);
    }
}

solve([2,3]);