function interest(input){
    let p = +input[0];
    let i = +input[1] / 100;
    let n = 12 / +input[2];
    let t = +input[3];

    let result = p * (1 + (i / n)) ** (n * t);
    return result.toFixed(2);
}

console.log(interest([1500, 4.3, 3, 6]));