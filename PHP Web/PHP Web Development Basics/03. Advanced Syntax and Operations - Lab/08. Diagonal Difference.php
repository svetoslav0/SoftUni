<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 4:41 PM
 */

$n = intval(readline());
$arr = [];

for($i = 0; $i < $n; $i++){
    $currentLine = array_map('intval', explode(' ', readline()));
    $arr[$i] = $currentLine;
}

$mainDiagonalSum = 0;
$secondDiagonalSum = 0;

for($i = 0; $i < $n; $i++){
    $mainNum = $arr[$i][$i];
    $secondaryNum = $arr[$i][$n - $i - 1];
    $mainDiagonalSum += $mainNum;
    $secondDiagonalSum += $secondaryNum;
}


echo abs($mainDiagonalSum - $secondDiagonalSum);
