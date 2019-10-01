function solve(arg) {
    if (typeof arg === "number") {
        let result = (Math.PI * (arg ** 2)).toFixed(2);
        console.log(result);
    } else {
        console.log(`We can not calculate the circle area, because we receive a ${typeof arg}.`)
    }
}

solve([]);