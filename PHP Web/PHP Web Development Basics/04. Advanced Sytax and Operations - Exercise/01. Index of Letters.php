<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 27-Sep-18
 * Time: 2:10 PM
 */

$input = strtolower(readline());
for($i = 0; $i <= strlen($input) - 1; $i++) {

    echo $input[$i] . " -> " . (ord($input[$i]) - 97) . PHP_EOL;
}
