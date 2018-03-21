function SymmetricNums(arr) {
    let n = Number(arr);
    for(let i = 1; i <= n; i++){
        let numAsStr = i + '';
        if(i == Number([...numAsStr].reverse().join(''))){
            console.log(i);
        }
    }
}

SymmetricNums('750');