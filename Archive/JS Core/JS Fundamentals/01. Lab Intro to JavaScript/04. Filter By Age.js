function filter(minimumAge, name1, age1, name2, age2){
    if(age1 >= minimumAge){
        console.log(`{ name: '${name1}', age: ${age1} }`);
    }
    if(age2 >= minimumAge){
        console.log(`{ name: '${name2}', age: ${age2} }`);
    }
}

filter(12, 'Ivan', 15, 'Asen', 9);