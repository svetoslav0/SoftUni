function objects(input){
    for(let i = 0; i < input.length; i++){
        let arr = input[i].split(' -> ');
        let name = arr[0];
        let age = arr[1];
        let grade = arr[2];
        console.log(`Name: ${name}`);
        console.log(`Age: ${age}`);
        console.log(`Grade: ${grade}`);
    }

}
<<<<<<< HEAD

objects(['Pesho -> 13 -> 6.00', 'Ivan -> 12 -> 5.57', 'Toni -> 13 -> 4.90']);


//Name: Pesho
//Age: 13
//Grade: 6.00
//Name: Ivan
//Age: 12
//Grade: 5.57
//Name: Toni
//Age: 13
//Grade: 4.90
=======
>>>>>>> 390451ad56165fdb72811a3f2ab621ad23b78faa
