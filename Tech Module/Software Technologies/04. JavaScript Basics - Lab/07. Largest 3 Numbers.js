function solve(arr) {
    function sortNumbers(a,b) {
        return a - b;
    }
    arr.sort(sortNumbers);
    for(let i = 0; i < 3; i++){
        let temp = arr.pop();
        if(temp != undefined){
            console.log(temp);
        }
    }

}
solve([10, 14, 32, 235, 1]);