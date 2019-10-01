function imperialUnits(foots){
    let inches = Math.floor(+foots / 12);
    let remainingFoots = +foots % 12;
    return `${inches}'-${remainingFoots}"`;
}

console.log(imperialUnits(11));