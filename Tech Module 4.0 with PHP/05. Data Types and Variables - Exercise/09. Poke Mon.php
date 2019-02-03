<?php

$n = doubleval(readline());
$m = doubleval(readline());
$y = doubleval(readline());

$halfN = $n / 2;
$pokesCount = 0;

while ($n >= $m){
    $n -= $m;
    $pokesCount++;

    if ($halfN == $n && $y != 0){
        $n = floor($n / $y);
    }
}

echo $n . PHP_EOL;
echo $pokesCount;

