function solve(number) {
    let numberAsString = String(number);

    let numsAreSame = true;
    for (let i = 0; i < numberAsString.length - 1; i++) {
        if (numberAsString[i] !== numberAsString[i+1]) {
            numsAreSame = false;
        }
    }

    let sum = 0;
    for (let i = 0; i < numberAsString.length; i++) {
        sum += +numberAsString[i];
    }

    console.log(numsAreSame);
    console.log(sum);
}

solve(1234);