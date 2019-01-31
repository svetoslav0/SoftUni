<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Oct-18
 * Time: 11:09 PM
 */

$n = intval(readline());

$arr = [];
while ($n-- > 0){
    list($currentName, $currentAge) = explode(' ', readline());
    $arr[] = [intval($currentAge), $currentName];
}

asort($arr);
$firstElement = array_pop($arr);
echo "$firstElement[1] $firstElement[0]";