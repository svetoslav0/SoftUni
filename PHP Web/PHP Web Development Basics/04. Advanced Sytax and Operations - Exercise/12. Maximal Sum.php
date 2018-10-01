<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 6:40 PM
 */

$sizes = array_map('intval', explode(' ', readline()));
$rows = $sizes[0];
$cols = $sizes[1];
$matrix = [];

for($i = 0; $i < $rows; $i++){
    $currentLine = array_map('intval', explode(' ', readline()));
    $matrix[$i] = $currentLine;
}

$bestRowIndex = 0;
$bestColIndex = 0;
$biggestSum = PHP_INT_MIN;
for($i = 0; $i < count($matrix) - 2; $i++){
    for($j = 0; $j < count($matrix[$i]) - 2; $j++){
        $currentSum = $matrix[$i][$j] + $matrix[$i][$j + 1] + $matrix[$i][$j + 2]
                    + $matrix[$i + 1][$j] + $matrix[$i + 1][$j + 1] + $matrix[$i + 1][$j + 2]
                    + $matrix[$i + 2][$j] + $matrix[$i + 2][$j + 1] + $matrix[$i + 2][$j + 2];
        if ($currentSum > $biggestSum){
            $biggestSum = $currentSum;
            $bestRowIndex = $i;
            $bestColIndex = $j;
        }
    }
}
echo "Sum = $biggestSum" . PHP_EOL;
echo $matrix[$bestRowIndex][$bestColIndex] . ' ' .$matrix[$bestRowIndex][$bestColIndex + 1]  . ' ' . $matrix[$bestRowIndex][$bestColIndex + 2] . PHP_EOL;
echo $matrix[$bestRowIndex + 1][$bestColIndex] . ' ' . $matrix[$bestRowIndex + 1][$bestColIndex + 1] . ' ' . $matrix[$bestRowIndex + 1][$bestColIndex + 2] . PHP_EOL;
echo $matrix[$bestRowIndex + 2][$bestColIndex] . ' ' . $matrix[$bestRowIndex + 2][$bestColIndex + 1] . ' ' . $matrix[$bestRowIndex + 2][$bestColIndex + 2] . PHP_EOL;
