function drawTriangle(num){
    for (let i = 0; i < num; i++) {
        console.log('*'.repeat(i + 1));
    }
    for(let i = num - 1; i >= 0; i--){
        console.log('*'.repeat(i));
    }
}

drawTriangle(3);