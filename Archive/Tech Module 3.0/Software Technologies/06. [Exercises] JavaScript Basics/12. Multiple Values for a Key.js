function solve(arr) {
    let result = [];

    for(line of arr) {
        let command = line.split(' ');
        if (command.length > 1) {
            if(result[command[0]] === undefined) {
                result[command[0]] = [command[1]];
            } else {
                result[command[0]].push(command[1]);
            }
        }
    }

    let key = arr.pop();
    if (result[key] === undefined)
        console.log('None');
    else
        result[key].forEach(x => console.log(x));
}

solve([
    '3 test',
    '3 test1',
    '4 test2',
    '4 test3',
    '4 test5',
    '4'
]);

//test2
//test3
//test5