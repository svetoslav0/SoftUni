<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 27-Sep-18
 * Time: 8:19 PM
 */

$array = array_map('intval', explode(' ',readline())); // 2 10 3
while(count($array) > 1){
    $current = [];
    for($j = 0; $j < count($array); $j++){
        $current[$j] = $array[$j]; // current = 2 10 3
    }
    for($j = 0; $j < count($array) - 1; $j++) {
        $array[$j] = $current[$j] + $current[$j + 1];
    }
    array_pop($array);
    unset($current);
}

echo $array[0];
