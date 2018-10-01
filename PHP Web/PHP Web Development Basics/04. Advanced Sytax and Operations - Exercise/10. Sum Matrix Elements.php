<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 27-Sep-18
 * Time: 8:38 PM
 */

$sizes = array_map('intval', explode(', ', readline()));
$rows = $sizes[0];
$cols = $sizes[1];
$matrix = [];
$sum = 0;

for($i = 0; $i < $rows; $i++){
    $currentLine = array_map('intval', explode(', ', readline()));
    $sum += array_sum($currentLine);
    $matrix[$i] = $currentLine;
}

echo $rows . PHP_EOL . $cols . PHP_EOL . $sum;



