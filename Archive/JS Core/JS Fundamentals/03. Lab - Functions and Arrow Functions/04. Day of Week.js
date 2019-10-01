function dayOfTheWeek(day){
    day = day.toLowerCase();
    if (day === 'monday') {
        return 1;
    } else if (day === 'tuesday') {
        return 2;
    } else if (day === 'wednesday') {
        return 3;
    } else if (day === 'thursday') {
        return 4;
    } else if (day === 'friday') {
        return 5;
    } else if (day === 'saturday') {
        return 6;
    } else if (day === 'sunday') {
        return 7;
    } else {
        return 'error';
    }
}