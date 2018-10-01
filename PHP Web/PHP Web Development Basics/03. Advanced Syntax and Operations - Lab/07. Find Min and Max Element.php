<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 1:24 PM
 */

$sizes = array_map('intval', explode( ', ', readline()));

$n = $sizes[0];
$arr = [];

for($i = 0; $i < $n; $i++){
    $currentLine = array_map('intval', explode(', ', readline()));
    $arr[$i] = $currentLine;
}

$max = PHP_INT_MIN;
$min = PHP_INT_MAX;

for($i = 0; $i < count($arr); $i++){
    for($j = 0; $j < count($arr[$i]); $j++){
        $current = $arr[$i][$j];
        if ($current > $max){
            $max = $current;
        }
        if ($current < $min){
            $min = $current;
        }
    }
}

echo "Min: $min" . PHP_EOL;
echo "Max: $max";
