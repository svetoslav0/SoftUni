function gradsToDegree(num){
    return ((num % 400) + 400) % 400 * 0.9;
}

console.log(gradsToDegree(-50));