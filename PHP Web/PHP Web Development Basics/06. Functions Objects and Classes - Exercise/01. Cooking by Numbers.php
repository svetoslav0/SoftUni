<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Oct-18
 * Time: 11:46 PM
 */

$num = doubleval(readline());

$arr = explode(', ', readline());
foreach ($arr as $command) {
    $num = Manipulate($num, $command);
    echo $num . PHP_EOL;
}

function Manipulate($num, $command){
    switch ($command) {
        case 'chop':
            return  $num / 2;
        case 'dice':
            return sqrt($num);
        case 'spice':
            return $num + 1;
        case 'bake':
            return $num * 3;
        case 'fillet':
            return $num * 0.8;
    }
    return $num;
}