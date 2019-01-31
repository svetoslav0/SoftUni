<?php

$num1 = intval(readline());
$num2 = intval(readline());

for($i = $num2; $i <= 10; $i++){
    echo "{$num1} X {$i} = " . $num1 * $i . PHP_EOL;
}

if ($num2 > 10){
    echo "{$num1} X {$num2} = " . $num1 * $num2 . PHP_EOL;
}