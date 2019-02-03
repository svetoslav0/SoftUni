<?php

$number = intval(readline());
for ($currentNumber = 2; $currentNumber <= $number; $currentNumber++) {
    $isPrime = true;
    for ($currentDivider = 2; $currentDivider < $currentNumber; $currentDivider++) {
        if ($currentNumber % $currentDivider == 0) {
            $isPrime = false;
            break;
        }
    }

    if ($isPrime)
        printf("%d -> true" . PHP_EOL, $currentNumber);
    else
        printf("%d -> false" . PHP_EOL, $currentNumber);
}
