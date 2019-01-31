<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 15-Nov-18
 * Time: 12:05 PM
 */

spl_autoload_register();

$length = doubleval(readline());
$width = doubleval(readline());
$height = doubleval(readline());

try {
    $b1 = new Box2($length, $width, $height);
    echo $b1;
}catch (Exception $e){
    echo $e->getMessage();
}

