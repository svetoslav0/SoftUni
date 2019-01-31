<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 03-Oct-18
 * Time: 7:44 PM
 */

$line = readline();
list($x1, $y1, $x2, $y2) = explode(', ', $line);

ResultPrint($x1, $y1, 0, 0);
ResultPrint($x2, $y2, 0, 0);
ResultPrint($x1, $y1, $x2, $y2);

function ResultPrint($x1, $y1, $x2, $y2){
    echo "{{$x1}, {$y1}} to {{$x2}, {$y2}} ";
    echo isValid($x1, $y1, $x2, $y2) ? 'is valid' . PHP_EOL : 'is invalid' . PHP_EOL;
}

function isValid($x1, $y1, $x2, $y2){
    $a = abs(doubleval($x1) - doubleval($x2));
    $b = abs(doubleval($y1) - doubleval($y2));
    $c = sqrt($a * $a + $b * $b);

    if ($c == intval($c)){
        return true;
    }
    return false;
}