function biggest(arr){
    return Math.max.apply(Math, arr);
}

console.log(biggest([5, -2, 7]));