<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 6:03 PM
 */

$num1 = (double)readline();
$num2 = (double)readline();
$operand = readline();

switch ($operand){
    case "sum":
        echo $num1 + $num2;
        break;
    case "subtract":
        echo $num1 - $num2;
        break;
    case "multiply":
        echo $num1 * $num2;
        break;
    case "divide":
        if ($num2 == 0){
            echo "Cannot divide by zero";
        }else{
            echo $num1 / $num2;
        }
        break;
    default:
        echo "Wrong operation supplied";
        break;
}