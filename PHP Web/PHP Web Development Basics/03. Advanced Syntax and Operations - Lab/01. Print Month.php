<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 26-Sep-18
 * Time: 1:09 PM
 */

$num = (int)readline();

$months = ["January", "February", "March", "April", "May", "June",  "July", "August", "September", "October", "November", "December"];

if ($num > 1 && $num <= 12){
    echo $months[$num - 1];
}else{
    echo "Invalid Month!";
}