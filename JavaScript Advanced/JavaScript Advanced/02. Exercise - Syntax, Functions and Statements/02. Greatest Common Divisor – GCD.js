function solve(firstNumber, secondNumber) {
    let minNumber = Math.min(firstNumber, secondNumber);

    for (let i = minNumber; i >= 1; i--) {

        if (firstNumber % i === 0 && secondNumber % i === 0) {
            console.log(i);
            break;
        }
    }
}

solve(2342310,31643251);