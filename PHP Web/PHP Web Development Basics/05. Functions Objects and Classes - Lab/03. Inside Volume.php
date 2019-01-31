<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 01-Oct-18
 * Time: 9:53 PM
 */

$arr = array_map('doubleval', explode(', ', readline()));
for($i = 0; $i < count($arr); $i += 3){
    $x = $arr[$i];
    $y = $arr[$i + 1];
    $z = $arr[$i + 2];
    echo isInside($x, $y, $z) ? "inside" . PHP_EOL : "outside" . PHP_EOL;
}

function isInside($x, $y, $z)
{
    if ($x >= 10 && $x <= 50) {
        if ($y >= 20 && $y <= 80) {
            if ($z >= 15 && $z <= 50) {
                return true;
            }
        }
    }
    return false;
}
