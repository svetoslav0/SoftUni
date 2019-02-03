<?php

$n = intval(readline());

while ($n-- > 0){
    $currentLine = explode(' ', readline());
    $num1 = $currentLine[0];
    $num2 = $currentLine[1];

    $currentSum = 0;
    $bigger = ($num1 > $num2) ? strval($num1) : strval($num2);

    for($i = 0; $i < strlen($bigger); $i++){
        if($bigger[$i] == '-'){
            continue;
        }

        $currentSum += intval($bigger[$i]);
    }

    echo $currentSum . PHP_EOL;
}