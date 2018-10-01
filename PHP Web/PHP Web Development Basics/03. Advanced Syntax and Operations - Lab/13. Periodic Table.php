<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 5:41 PM
 */

$input = explode(', ', readline());
$assArr = [];

for($i = 0; $i < count($input); $i++){
    $current = $input[$i];
    if (!array_key_exists($current, $assArr)){
        $assArr[$current] = 0;
    }
    $assArr[$current]++;
}

foreach ($assArr as $element => $appeared) {
    if ($appeared == 1){
        echo "$element ";
    }
}