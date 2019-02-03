<?php

$n = intval(readline());

for($i = 0; $i < $n; $i++){
    for($j = 0; $j < $n; $j++){
        for($k = 0; $k < $n; $k++){
            echo chr(97 + $i) . chr(97 + $j) . chr(97 + $k) . PHP_EOL;
        }
    }
}