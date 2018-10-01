<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 6:16 PM
 */

$num = (int)readline();

for($i = 1; $i <= 15; $i++){
    $sum = 0;
    $currentNum = $i;
    while ($currentNum != 0){
        $sum += $currentNum % 10;
        $currentNum /= 10;
    }
    if ($sum == 5 || $sum == 7 || $sum == 11){
        echo "$i -> True\r\n";
    }else{
        echo "$i -> False\r\n";
    }

}