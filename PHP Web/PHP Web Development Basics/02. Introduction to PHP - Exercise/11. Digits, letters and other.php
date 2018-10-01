<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 8:02 PM
 */

$text = readline();

$digits = "";
$letters = "";
$others = "";


for($i = 0; $i < strlen($text); $i++){
    if (isDigit($text[$i]) == true){
        $digits .= $text[$i];
    }else if (isLetter($text[$i]) == true){
        $letters .= $text[$i];
    }else{
        $others .= $text[$i];
    }
}

echo $digits . PHP_EOL;
echo $letters . PHP_EOL;
echo $others;

function isDigit($ch){
    $ch = ord($ch);
    if ($ch >= 48 && $ch <= 57){
        return true;
    }else{
        return false;
    }
}
function isLetter($ch){
    $ch = ord($ch);
    if (($ch >= 65 && $ch <= 90) || ($ch >= 97 && $ch <= 122)){
        return true;
    }else{
        return false;
    }
}