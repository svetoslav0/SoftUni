function solve(input) {
    for(let i = 0; i < input.length; i++){
        let object = JSON.parse(input[i]);
        console.log(`Name: ${object.name}`);
        console.log(`Age: ${object.age}`);
        console.log(`Date: ${object.date}`);
    }
}
