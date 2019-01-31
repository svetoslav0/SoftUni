<?php

$n = intval(readline());

$totalBoxes = 0;
while ($n-- > 0){
    $flourGrams = doubleval(readline());
    $sugarGrams = doubleval(readline());
    $cocoaGrams = doubleval(readline());

    $flourCups = $flourGrams / 140;
    $sugarSpoons = $sugarGrams / 20;
    $cocoaSpoons = $cocoaGrams / 10;

    $totalCookies = 170 * min($flourCups, $sugarSpoons, $cocoaSpoons) / 25;
    $currentBoxes = floor($totalCookies / 5);

    if ($currentBoxes < 1){
        echo 'Ingredients are not enough for a box of cookies.' . PHP_EOL;
    } else {
        echo "Boxes of cookies: {$currentBoxes}" . PHP_EOL;
        $totalBoxes += $currentBoxes;
    }
}

echo "Total boxes: {$totalBoxes}";