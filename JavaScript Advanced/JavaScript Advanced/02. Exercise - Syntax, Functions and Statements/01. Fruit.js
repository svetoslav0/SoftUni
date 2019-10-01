function solve(fruit, weight, price) {
    let moneyNeeded = (weight * price / 1000).toFixed(2);
    let weightInKg = (weight / 1000).toFixed(2);

    console.log(`I need $${moneyNeeded} to buy ${weightInKg} kilograms ${fruit}.`);
}

solve('orange', 2500, 1.80);