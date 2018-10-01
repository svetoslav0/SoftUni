<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 6:43 PM
 */

$num1 = (int)readline();
$num2 = (int)readline();

$smaller = min($num1, $num2);
$bigger = max($num1, $num2);

for ($i = $smaller; $i <= $bigger; $i++){
    echo "$i\r\n";
}
