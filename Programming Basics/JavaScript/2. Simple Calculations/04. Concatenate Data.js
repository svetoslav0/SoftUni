function Concatenate([arg1, arg2, arg3, arg4]){
    let firstName = arg1;
    let lastName = arg2;
    let age = arg3;
    let city = arg4;
    console.log(`You are ${firstName} ${lastName}, a ${age}-years old person from ${city}.`);
}

Concatenate(["Svetlin", "Nakov", "25", "Veliko tarnovo"]);