<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 6:33 PM
 */


$num1 = (double)readline();
$num2 = (double)readline();

echo "\$firstNumber + \$secondNumber = $num1 + $num2 = " . number_format($num1 + $num2, 2,".","");
