<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 27-Sep-18
 * Time: 2:21 PM
 */

$nums = explode(' ', readline());

for($i = 0; $i < count($nums); $i++){
    $nums[$i] = (int)strrev($nums[$i]);
}

$sum = array_sum($nums);

echo $sum;