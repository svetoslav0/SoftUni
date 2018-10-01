<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 6:11 PM
 */

$input = readline();

while ($input != "end"){
    echo "$input = " . strrev($input) . "\r\n";
    $input = readline();
}