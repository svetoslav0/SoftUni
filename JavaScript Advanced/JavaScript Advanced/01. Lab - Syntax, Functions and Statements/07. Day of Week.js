function solve(day) {
    const days = {
        'Monday': 1,
        'Tuesday': 2,
        'Wednesday': 3,
        'Thursday': 4,
        'Friday': 5,
        'Saturday': 6,
        'Sunday': 7
    };

    console.log(days[day] ? days[day] : 'error');
}

solve('Friday');