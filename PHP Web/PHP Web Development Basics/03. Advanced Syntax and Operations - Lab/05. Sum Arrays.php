<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 28-Sep-18
 * Time: 7:22 PM
 */

$arr1 = array_map('intval', explode(' ', readline()));
$arr2 = array_map('intval', explode(' ', readline()));

if (count($arr1) > count($arr2)){
    $maxLength = count($arr1);
    $minLength = count($arr2);
    for($i = 0; $i < $maxLength - $minLength; $i++){
        array_push($arr2, $arr2[$i % $maxLength]);
    }
}elseif(count($arr2) > count($arr1)){
    $maxLength = count($arr2);
    $minLength = count($arr1);
    for($i = 0; $i < $maxLength - $minLength; $i++){
        array_push($arr1, $arr1[$i % $maxLength]);
    }
}

$sum = [];
for($i = 0; $i < count($arr1); $i++){
    array_push($sum, $arr1[$i] + $arr2[$i]);
}

echo implode(' ', $sum);

