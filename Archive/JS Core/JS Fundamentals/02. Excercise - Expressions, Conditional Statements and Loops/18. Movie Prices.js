function moviePrices(input){
    let movie = input[0].toLowerCase();
    let day = input[1].toLowerCase();

    let price = -1;
    if (movie === 'the godfather'){
        if (day === 'monday'){
            price = 12;
        } else if (day === 'tuesday') {
            price = 10;
        } else if (day === 'wednesday') {
            price = 15;
        } else if (day === 'thursday') {
            price = 12.5;
        } else if (day === 'friday') {
            price = 15;
        } else if (day === 'saturday') {
            price = 25;
        } else if (day === 'sunday') {
            price = 30;
        }
    } else if (movie === 'schindler\'s list') {
        if (day === 'monday' || day === 'tuesday' || day === 'wednesday' || day === 'thursday' || day === 'friday'){
            price = 8.5;
        } else if (day === 'saturday' || day === 'sunday') {
            price = 15;
        }
    } else if (movie === 'casablanca') {
        if (day === 'monday' || day === 'tuesday' || day === 'wednesday' || day === 'thursday' || day === 'friday'){
            price = 8;
        } else if (day === 'saturday' || day === 'sunday') {
            price = 10;
        }
    } else if (movie === 'the wizard of oz') {
        if (day === 'monday' || day === 'tuesday' || day === 'wednesday' || day === 'thursday' || day === 'friday'){
            price = 10;
        } else if (day === 'saturday' || day === 'sunday') {
            price = 15;
        }
    }

    if (price !== -1){
        return price;
    }
    return 'error';
}

console.log(moviePrices(['casablanca', 'sunday']));