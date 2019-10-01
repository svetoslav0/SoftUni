function solve(params) {
    let number = +params.shift();

    params.forEach(function (operation) {
        switch (operation) {
            case 'chop':
                console.log(number = number / 2);
                break;
            case 'dice':
                console.log(number = Math.sqrt(number));
                break;
            case 'spice':
                console.log(number += 1);
                break;
            case 'bake':
                console.log(number *= 3);
                break;
            case 'fillet':
                console.log(number = number * 8 / 10);
                break;
            default:
                console.log('Error');
                break;
        }
    })
}

solve(['9', 'dice', 'spice', 'chop', 'bake', 'fillet']);