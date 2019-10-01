function solve(message) {
    let regex = /\w+/g;
    let matches = message
        .match(regex)
        .map(match => match.toUpperCase())
        .join(', ');

    console.log(matches);
}

solve('Hi, how are you?');