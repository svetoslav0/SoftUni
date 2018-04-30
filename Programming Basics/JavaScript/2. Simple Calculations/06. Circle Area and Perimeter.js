function Solve([arg]){
    let r = Number(arg);
    let area = Math.PI * r * r;
    let perimeter = 2 * Math.PI * r;
    console.log(`Area = ${area}`);
    console.log(`Perimeter = ${perimeter}`); 
}

Solve([3]);