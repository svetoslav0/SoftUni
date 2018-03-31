function solve(input) {
    for(let i = 0; i < input.length; i++){
        let object = JSON.parse(input[i]);
        console.log(`Name: ${object.name}`);
        console.log(`Age: ${object.age}`);
        console.log(`Date: ${object.date}`);
    }
}
<<<<<<< HEAD



solve(['{"name":"Gosho","age":10,"date":"19/06/2005"}','{"name":"Tosho","age":11,"date":"04/04/2005"}']);
=======
>>>>>>> 390451ad56165fdb72811a3f2ab621ad23b78faa
