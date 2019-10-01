function solve(steps, stepLength, speedInKmH) {
    function pad(num, size) {
        let s = "00" + num;
        return s.substr(s.length-size);
    }

    let distance = steps * stepLength;
    let breaks = Math.floor(distance / 500);
    let speedInMSec = speedInKmH / 3.6;
    let timeInSeconds = distance / speedInMSec + breaks * 60;

    let hours = Math.floor(timeInSeconds / 3600);
    let minutes = Math.floor(timeInSeconds / 60) % 60;
    let seconds = Math.round(timeInSeconds % 60);

    console.log(`${pad(hours, 2)}:${pad(minutes, 2)}:${pad(seconds, 2)}`);
}



solve(4000, 0.60, 5);
solve(2564, 0.70, 5.5);
solve(14000, 0.70, 5.5);