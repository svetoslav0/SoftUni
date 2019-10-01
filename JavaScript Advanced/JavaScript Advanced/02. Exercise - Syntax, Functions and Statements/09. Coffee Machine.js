function solve(orders) {

    let totalIncome = 0;

    orders.forEach(order => {
        let orderArgs = order.split(', ');
        let insertedMoney = +orderArgs[0];
        let drink = orderArgs[1];

        let drinkPrice = 0;
        if (drink === 'tea') {
            drinkPrice = 0.8;
        } else if (drink === 'coffee') {
            let coffeeType = orderArgs[2];
            if (coffeeType === 'caffeine') {
                drinkPrice = 0.8;
            } else if (coffeeType === 'decaf') {
                drinkPrice = 0.9;
            }
        }

        let milkPrice = 0;
        if (order.includes('milk')) {
            milkPrice = Math.round(drinkPrice) / 10;
        }

        let sugarQuantity = +orderArgs[orderArgs.length - 1];
        let sugarPrice = 0;
        if (sugarQuantity !== 0) {
            sugarPrice = 0.1;
        }

        let totalPrice = drinkPrice + milkPrice + sugarPrice;

        if (totalPrice <= insertedMoney) {
            let change = insertedMoney - totalPrice;
            totalIncome += totalPrice;
            console.log(`You ordered ${drink}. Price: $${totalPrice.toFixed(2)} Change: $${change.toFixed(2)}`);
        } else {
            let neededMoney = totalPrice - insertedMoney;
            console.log(`Not enough money for ${drink}. Need $${neededMoney.toFixed(2)} more.`);
        }
    });

    console.log(`Income Report: $${totalIncome.toFixed(2)}`);
}

// solve(['1.00, coffee, caffeine, milk, 4', '0.40, tea, milk, 2', '1.00, coffee, decaf, 0']);
solve(['8.00, coffee, decaf, 4', '1.00, tea, 2']);