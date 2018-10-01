<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 7:24 PM
 */

$text = readline();
$operators = explode(" ", readline());
$ch = $operators[0];
$n = $operators[1];
$pos = 0;
$needle = -1;
for ($i = 0; $i < $n; $i++){
    $pos = strpos($text, $ch, $needle + 1);
    $needle = $pos;
}
if ($pos != null) {
    echo $pos;
}else{
    echo "Find the letter yourself!";
}