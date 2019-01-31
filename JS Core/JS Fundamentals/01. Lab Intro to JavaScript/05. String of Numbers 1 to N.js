function concat(n){
    let result = '';
    let number = +n;
    for (let i = 1; i <= n; i++) {
        result += i;
    }
    console.log(result);
}

concat('11');