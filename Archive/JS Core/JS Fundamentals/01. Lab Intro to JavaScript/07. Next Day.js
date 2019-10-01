function nextDay(year, month, day){
    let newYear = year;
    let newMonth = month;
    let newDay = day + 1;

    if (newYear < 1900) {
        newYear += 1900;
    }

    switch (month) {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            if (newDay > 31) {
                newMonth++;
                newDay = 1;
            }
            break;
        case 4:
        case 6:
        case 9:
        case 11:
            if(newDay > 30){
                newMonth++;
                newDay = 1;
            }
            break;
        default:
            if(newYear % 4 == 0 && newDay > 29){
                newMonth++;
                newDay = 1;
            } else if(newYear % 4 != 0 && newDay > 28) {
                newMonth++;
                newDay = 1;
            }
            break;
    }   

    if (newMonth > 12) {
        newYear++;
        newMonth = 1;
    }

    console.log(`${newYear}-${newMonth}-${newDay}`);
}

nextDay(2016, 2, 28);