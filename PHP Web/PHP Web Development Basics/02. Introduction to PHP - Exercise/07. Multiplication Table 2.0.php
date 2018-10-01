<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 6:52 PM
 */

$num1 = (int)readline();
$num2 = (int)readline();

do{
    echo "$num1 X $num2 = " . $num1 * $num2 . "\r\n";
    $num2++;
}while($num2 <= 10);