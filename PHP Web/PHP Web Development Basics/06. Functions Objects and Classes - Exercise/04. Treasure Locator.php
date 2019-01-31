<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 03-Oct-18
 * Time: 8:03 PM
 */

$line = explode(', ' , readline());
for($i = 0; $i < count($line); $i += 2){
    $x = doubleval($line[$i]);
    $y = doubleval($line[$i + 1]);
    Locate($x, $y);
}

function Locate($x, $y){
    if ($x >= 1 && $x <= 3 && $y >= 1 && $y <= 3){
        echo 'Tuvalu' . PHP_EOL;
    }elseif ($x >= 8 && $x <= 9 && $y >= 0 && $y <= 1){
        echo 'Tokelau' . PHP_EOL;
    }elseif ($x >= 0 && $x <= 2 && $y >= 6 && $y <= 8){
        echo 'Tonga' . PHP_EOL;
    }elseif ($x >= 5 && $x <= 7 && $y >= 3 && $y <= 6){
        echo 'Samoa' . PHP_EOL;
    }elseif ($x >= 4 && $x <= 9 && $y >= 7 && $y <= 8){
        echo 'Cook' . PHP_EOL;
    }else{
        echo 'On the bottom of the ocean' . PHP_EOL;
    }
}
