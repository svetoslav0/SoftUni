<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Dec-18
 * Time: 5:58 PM
 */
spl_autoload_register();

$n = intval(readline());
$songs = [];
$totalSeconds = 0;

while($n-- > 0){
    list($artist, $songName, $songLength) = explode(';', readline());
    if ($songLength == ''){
        echo 'Invalid song length.' . PHP_EOL;
        continue;
    }
    list($minutes, $seconds) = explode(':', $songLength);

    try{
        $song = new Song($artist, $songName, $minutes, $seconds);
        echo 'Song added.' . PHP_EOL;
        $songs[] = $song;
        $totalSeconds += $minutes * 60 + $seconds;
    }catch (Exception $e){
        echo $e->getMessage() . PHP_EOL;
    }
}

echo 'Songs added: ' . count($songs) . PHP_EOL;
echo Song::getTotalTime($totalSeconds);