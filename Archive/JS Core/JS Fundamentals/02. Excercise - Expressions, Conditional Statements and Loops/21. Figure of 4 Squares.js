function figure(n){
    if(n % 2 === 0){
        for (let i = 0; i < n - 1; i++) {
            if (i === 0 || i === n / 2 - 1 || i === n - 2){
                console.log("+" + "-".repeat(n - 2) + "+" + "-".repeat(n - 2) + "+");   
            } else {
                console.log("|" + " ".repeat(n - 2) + "|" + " ".repeat(n - 2) + "|");   
            }
        }
    } else {
        for (let i = 0; i < n; i++) {
            if (i === 0 || i === (n - 1) / 2 || i === n - 1){
                console.log("+" + "-".repeat(n - 2) + "+" + "-".repeat(n - 2) + "+");   
            } else {
                console.log("|" + " ".repeat(n - 2) + "|" + " ".repeat(n - 2) + "|");   
            }
        }
    }
}

figure(5);