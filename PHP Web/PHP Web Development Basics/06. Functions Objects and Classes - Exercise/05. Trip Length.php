<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 03-Oct-18
 * Time: 10:06 PM
 */


list($x1, $y1, $x2, $y2, $x3, $y3) = array_map('doubleval',explode(', ', readline()));

$line0 = [0 => line_length($x1, $y1, $x2, $y2)];
$line1 = [1 => line_length($x1, $y1, $x3, $y3)];
$line2 = [2 => line_length($x2, $y2, $x3, $y3)];

$longest_line = max($line0[0], $line1[1], $line2[2]);
$middle_line = find_middle_number($line0, $line1, $line2);
$shortest_line = min($line0, $line1, $line2);

// NOT FINISHED


function line_length($m1, $n1, $m2, $n2){
    $a = abs($m1 - $m2);
    $b = abs($n1 - $n2);
    return sqrt($a * $a + $b * $b);
}

function find_middle_number($num1, $num2, $num3){
    $arr = [$num1, $num2, $num3];
    sort($arr);
    return $arr[1];
}

function find_max($num1, $num2, $num3){
    
}