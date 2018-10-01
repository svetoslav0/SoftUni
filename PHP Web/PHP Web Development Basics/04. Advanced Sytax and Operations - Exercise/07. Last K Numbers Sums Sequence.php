<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 27-Sep-18
 * Time: 3:01 PM
 */

$n = (int)readline();
$k = (int)readline();
$array = [1];

for ($i = 0; $i < $n - 1; $i++){
    $start = count($array) - $k;
    if ($start < 0){
        $start = 0;
    }
    $slice = array_slice($array, $start, $k);
    $sum = array_sum($slice);
    array_push($array, $sum);
}

echo implode(" ", $array);