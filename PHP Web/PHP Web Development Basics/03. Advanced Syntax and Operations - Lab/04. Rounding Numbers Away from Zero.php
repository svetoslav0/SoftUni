<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 28-Sep-18
 * Time: 7:07 PM
 */

$array = explode(' ', readline());

foreach ($array as $str) {
    $num = doubleval($str);
    echo "$str => " . round($num, 0, PHP_ROUND_HALF_UP) .PHP_EOL;
}