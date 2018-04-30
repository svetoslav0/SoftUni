function Solve([arg1, arg2, arg3, arg4]){
    let x1 = Number(arg1);
    let y1 = Number(arg2);
    let x2 = Number(arg3);
    let y2 = Number(arg4);

    let a = Math.abs(x1 - x2);
    let b = Math.abs(y1 - y2);
    
    let area = a * b;
    let per = 2 * (a + b);

    console.log(area);
    console.log(per);


}

Solve([60, 20, 10, 50]);