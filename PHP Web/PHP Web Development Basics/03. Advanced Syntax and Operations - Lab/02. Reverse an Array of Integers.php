<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 28-Sep-18
 * Time: 9:31 AM
 */

$n = (int)readline();
$array = [];

for($i = 0; $i < $n; $i++){
    $currentNum = (int)readline();
    array_push($array, $currentNum);
}
$array = array_reverse($array);

echo implode(" ", $array);