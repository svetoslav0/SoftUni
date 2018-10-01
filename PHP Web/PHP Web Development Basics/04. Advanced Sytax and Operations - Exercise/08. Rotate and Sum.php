<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 27-Sep-18
 * Time: 6:39 PM
 */

$array = array_map('intval', explode(" ", readline()));
$rotations = (int)readline();
$length = count($array);

//Create an array filled with zeros
for($i = 0; $i < $length; $i++){
    $summedArray = array_fill(0, $length, 0);
}


for($i = 0; $i < $rotations; $i++){
    $last = array_pop($array);
    array_unshift($array, $last);

    for($j = 0; $j < $length; $j++){
        $summedArray[$j] += $array[$j];
    }
}

echo implode(" ", $summedArray);