function product(arr) {
    let num1 = Number(arr[0]);
    let num2 = Number(arr[1]);
    let num3 = Number(arr[2]);
    let negativeCounter = 0;
    if(num1 == 0 || num2 == 0 || num3 == 0){
        console.log("Positive");
        return;
    }
    if(num1 < 0){
        negativeCounter++;
    }
    if(num2 < 0){
        negativeCounter++;
    }
    if(num3 < 0){
        negativeCounter++;
    }
    if(negativeCounter % 2 == 0){
        console.log("Positive");
    }
    else{
        console.log("Negative");
    }
}

product([1, -3, -1]);