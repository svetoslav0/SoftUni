<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 27-Sep-18
 * Time: 2:55 PM
 */



$nums = explode(' ', readline());

$bestIndex = 0;
$bestLength = 1;
$currentIndex = 0;
$currentLength = 1;

for ($i = 1; $i < count($nums); $i++){
    if ($nums[$i] > $nums[$i - 1]){
        $currentIndex = $i;
        $currentLength++;
        if ($currentLength > $bestLength) {
            $bestIndex = $currentIndex;
            $bestLength = $currentLength;
        }
    }else{
        $currentIndex = 0;
        $currentLength = 1;
    }
}

$output = array_slice($nums, $bestIndex - $bestLength + 1, $bestLength);
echo implode(" ", $output);
