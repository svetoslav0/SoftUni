function solve(params){
    let speed = +params[0];
    let area = params[1];

    let limits = {
        'motorway': 130,
        'interstate': 90,
        'city': 50,
        'residential': 20
    };

    let currentLimit = limits[area];
    let overSpeeding = speed - currentLimit;

    if (overSpeeding > 40) {
        console.log('reckless driving');
    } else if (overSpeeding > 20) {
        console.log('excessive speeding');
    } else if (overSpeeding > 0) {
        console.log('speeding');
    }
}

solve([200, 'motorway']);