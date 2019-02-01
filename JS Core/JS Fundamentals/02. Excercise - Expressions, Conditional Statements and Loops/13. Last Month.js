function lastMonth([day, month, year]){
    let date = new Date(year, month - 1, 0);
    let lastDay = date.getDate();
    return lastDay;
}

console.log(lastMonth([17, 3, 2002]));