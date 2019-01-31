<?php

$num = abs(intval(readline()));

while (true){
    if ($num % 2 == 0){
        echo "The number is: {$num}";
        break;
    } else{
        echo "Please write an even number." . PHP_EOL;
        $num = abs(intval(readline()));
    }
}