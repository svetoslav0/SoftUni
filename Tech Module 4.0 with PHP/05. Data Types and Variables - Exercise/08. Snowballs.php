<?php

$n = intval(readline());
$bestSnow = 0;
$bestTime = 0;
$bestQuality = 0;
$bestValue = 0;

while($n-- > 0){
    $currentSnow = intval(readline());
    $currentTime = intval(readline());
    $currentQuality = intval(readline());
    $currentValue = bcpow($currentSnow / $currentTime, $currentQuality);
    if ($currentValue > $bestValue){
        $bestSnow = $currentSnow;
        $bestTime = $currentTime;
        $bestQuality = $currentQuality;
        $bestValue = $currentValue;
    }
}

echo "{$bestSnow} : {$bestTime} = {$bestValue} ({$bestQuality})";
