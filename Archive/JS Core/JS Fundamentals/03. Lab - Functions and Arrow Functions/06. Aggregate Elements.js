function aggregateElements(arr){
    let sum = (function (arr) {
        let sum = 0;
        for (let i = 0; i < arr.length; i++) {
            sum += arr[i];
        }
        return sum;
    })(arr);
    
    let inverseSum = (function (arr) {
        let sum = 0;
        for (let i = 0; i < arr.length; i++) {
            sum += 1 / arr[i];
        }
        return sum;
    })(arr);

    let concat = (function (arr) {
        let result = '';
        for (let i = 0; i < arr.length; i++) {
            result += arr[i];
        }
        return result;
    })(arr);

    console.log(sum);
    console.log(inverseSum);
    console.log(concat);
}

aggregateElements([1, 2, 3]);