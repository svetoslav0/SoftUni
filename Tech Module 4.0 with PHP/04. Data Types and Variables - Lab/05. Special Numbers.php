<?php

$n = intval(readline());

for($i = 1; $i <= $n; $i++){
    if (sumOfDigits($i) == 5 || sumOfDigits($i) == 7 || sumOfDigits($i) == 11){
        echo "{$i} -> True" . PHP_EOL;
    } else {
        echo "{$i} -> False" . PHP_EOL;
    }
}

function sumOfDigits($num){
    $numAsStr = strval($num);
    $sum = 0;

    for($i = 0; $i < strlen($numAsStr); $i++){
        $sum += intval($numAsStr[$i]);
    }

    return $sum;
}