<?php

$num = intval(readline());
$currentSum = 0;
$currentNumber = 0;
$toe = false;

for ($i = 1; $i <= $num; $i++) {
    $currentNumber = $i;
    while ($i > 0) {
        $currentSum += $i % 10;
        $i = $i / 10;
    }
    $toe = ($currentSum == 5) || ($currentSum == 7) || ($currentSum == 11);
    $isSpecial = $toe ? "True" : "False";
    echo sprintf("%d -> %s", $currentNumber, $isSpecial) . PHP_EOL;
    $currentSum = 0;
    $i = $currentNumber;
}
