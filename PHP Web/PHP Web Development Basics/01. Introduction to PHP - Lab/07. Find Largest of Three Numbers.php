<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 6:08 PM
 */

$num1 = (int)readline();
$num2 = (int)readline();
$num3 = (int)readline();

$largestOfTwo = max($num1, $num2);
$largest = max($largestOfTwo, $num3);
echo $largest;