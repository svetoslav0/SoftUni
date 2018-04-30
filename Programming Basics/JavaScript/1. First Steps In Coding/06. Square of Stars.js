function Square([arg]){
    let n = Number(arg);
    let line = "";
    for(let i = 0; i < n; i++){
        line += "*"
    }
    let middle = "*";
    for(let i = 0; i < n - 2; i++){
        middle += " ";
    }
    middle += "*";
    
    console.log(line);
    for(let i = 0; i < n - 2; i++){
        console.log(middle);
    }

    console.log(line);

}

Square([3]);