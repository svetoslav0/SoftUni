<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 03-Oct-18
 * Time: 12:02 AM
 */

$numAsStr = intval(readline());
while(1){
    $avg = CalculateAvg($numAsStr);
    echo 'Avg: ' . $avg . PHP_EOL;
    if ($avg > 5){
        echo $numAsStr;
        break;
    }
    $numAsStr = AddDigit($numAsStr);
}

function CalculateAvg($numAsStr){
    $numAsStr = (string)$numAsStr;
    $sum = 0;
    for($i = 0; $i < strlen($numAsStr); $i++){
        $sum += doubleval($numAsStr[$i]);
    }
    return $sum / strlen($numAsStr);
}

function AddDigit($numAsStr){
    return (string)(doubleval($numAsStr) * 10 + 9);
}
