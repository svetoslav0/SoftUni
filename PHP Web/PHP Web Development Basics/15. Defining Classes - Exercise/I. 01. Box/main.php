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

$b1 = new Box($length, $width, $height);
echo $b1;