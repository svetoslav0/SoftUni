function solve(params) {
    let x1 = params[0];
    let y1 = params[1];
    let x2 = params[2];
    let y2 = params[3];

    let first = Math.sqrt(x1 * x1 + y1 * y1);
    if (Number.isInteger(first)) {
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    } else {
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }

    let second = Math.sqrt(x2 * x2 + y2 * y2);
    if (Number.isInteger(second)) {
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    } else {
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }

    let a = Math.abs(x2 - x1);
    let b = Math.abs(y2 - y1);
    let third = Math.sqrt(a * a + b * b);
    if (Number.isInteger(third)) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    } else {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }

}

solve([3, 0, 0, 4]);