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
