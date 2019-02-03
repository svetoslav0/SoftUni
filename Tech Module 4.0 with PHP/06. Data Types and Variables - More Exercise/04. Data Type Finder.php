<?php

do{
    $line = readline();
    if ($line == 'END'){
        break;
    }

    if (is_numeric($line)){
        if (strpos($line, '.')){
            echo "{$line} is floating point type";
        } else {
            echo "{$line} is integer type";
        }
    } elseif (strtolower($line) == 'true' || strtolower($line) == 'false'){
        echo "{$line} is boolean type";
    } elseif (strlen($line) == 1){
        echo "{$line} is character type";
    } else {
        echo "{$line} is string type";
    }
    echo PHP_EOL;
}while(true);