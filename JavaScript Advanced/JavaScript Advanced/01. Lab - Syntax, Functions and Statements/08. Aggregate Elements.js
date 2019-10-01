function solve(arr) {

    let sum = arr.reduce((a, b) => a + b, 0);
    let inverseSum = arr.reduce((a, b) => a + 1/b, 0);
    let concatted = arr.reduce((a, b) => a + b.toString(), '');

    console.log(sum);
    console.log(inverseSum);
    console.log(concatted);
}

solve([1, 2, 3]);
solve([2, 4, 8, 16]);