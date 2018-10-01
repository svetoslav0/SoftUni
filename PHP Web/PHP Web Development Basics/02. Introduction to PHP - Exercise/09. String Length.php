<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 7:17 PM
 */

$text = readline();
$length = strlen($text);

if ($length < 20){
    echo $text;
    for($i = $length; $i < 20; $i++){
        echo "*";
    }
}else{
    echo substr($text, 0, 20);
}

