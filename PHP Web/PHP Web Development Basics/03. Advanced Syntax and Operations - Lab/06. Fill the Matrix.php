<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 1:08 PM
 */

$input = explode(', ', readline());
$n = intval($input[0]);
$pattern = $input[1];

if ($pattern == 'A'){
    FillPatternA($n);
}elseif($pattern == 'B'){
    FillPatternB($n);
}


function FillPatternA($n){
    $arr = [];
    $counter = 1;
    for($i = 0; $i < $n; $i++){
        for($j = 0; $j < $n; $j++){
            $arr[$j][$i] = $counter++;
        }
    }
    MatrixPrint($arr);
}
function FillPatternB($n){
    $arr = [];
    $counter = 1;
    for($i = 0; $i < $n; $i++){
        if ($i % 2 == 0) {
            for ($j = 0; $j < $n; $j++) {
                $arr[$j][$i] = $counter++;
            }
        }
        else{
            for($j = $n - 1; $j >= 0; $j--){
                $arr[$j][$i] = $counter++;
            }
        }
    }
    MatrixPrint($arr);
}
function MatrixPrint($arr){
    foreach ($arr as $row) {
        echo implode(' ', $row).PHP_EOL;
    }
}