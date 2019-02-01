function rounding(input){
    let number = +input[0];
    let percision = +input[1];

    if(percision > 15){
        percision = 15;
    }

    return +number.toFixed(percision);
}