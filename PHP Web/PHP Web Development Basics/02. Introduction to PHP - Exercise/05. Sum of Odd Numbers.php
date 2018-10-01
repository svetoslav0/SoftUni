<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 6:46 PM
 */

$num = (int)readline();
$sum = 0;
for($i = 0, $currentNum = 1; $i < $num; $i++, $currentNum += 2){
    echo "$currentNum\r\n";
    $sum += $currentNum;
}
echo "Sum: $sum\r\n";