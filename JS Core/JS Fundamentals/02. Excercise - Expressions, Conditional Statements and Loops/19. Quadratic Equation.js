function quadraticEquation(a, b, c){

    let d = b ** 2 - 4 * a * c;
    
    if (d > 0){
        console.log((-b - Math.sqrt(d)) / (2 * a));
        console.log((-b + Math.sqrt(d)) / (2 * a));
    } else if (d === 0){
        console.log(-b / (2 * a));
    } else {
        console.log('No');
    }
}

quadraticEquation(6, 11, -35);

