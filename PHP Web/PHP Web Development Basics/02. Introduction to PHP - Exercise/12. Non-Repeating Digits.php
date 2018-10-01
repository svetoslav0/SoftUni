<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 9:24 PM
 */

$num = (int)readline();
$array = array();

for ($i = 102; $i <= $num; $i++){
    if ($i > 999){
        break;
    }
    $currentNum = $i;
    $subNum1 = $currentNum % 10;
    $currentNum /= 10;
    $subNum2 = $currentNum % 10;
    $currentNum /= 10;
    $subNum3 = $currentNum % 10;
    if ($subNum1 != $subNum2 && $subNum1 != $subNum3 && $subNum2 != $subNum3){
        array_push($array, $i);
    }
}

if (!empty($array)){
    echo implode(", ", $array);
}else{
    echo "no";
}