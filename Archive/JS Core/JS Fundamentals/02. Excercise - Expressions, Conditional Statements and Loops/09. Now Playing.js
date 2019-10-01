function nowPlaying([trackName, artistName, duration]){
    return `Now Playing: ${artistName} - ${trackName} [${duration}]`;
}

console.log(nowPlaying(['Number One', 'Nelly', '4:09']));