function distance(input){
    let v = Math.abs(+input[0] - +input[1]);
    let s = v * +input[2] / 3600;
    console.log(s * 1000);
}

distance([11, 10, 120]);