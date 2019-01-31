<?php

$startNum = intval(readline());
$endNum = intval(readline());
$sum = 0;

for($i = $startNum; $i <= $endNum; $i++){
    echo $i . ' ';
    $sum += $i;
}
 echo PHP_EOL . "Sum: {$sum}";