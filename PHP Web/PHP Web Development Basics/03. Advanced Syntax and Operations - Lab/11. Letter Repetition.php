<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 5:23 PM
 */
$input = readline();
$assArr = [];

for($i = 0; $i < strlen($input); $i++){
    $currentChar = $input[$i];
    if (!array_key_exists($currentChar, $assArr)){
        $assArr[$currentChar] = 0;
    }
    $assArr[$currentChar]++;
}

foreach ($assArr as $char => $appeared) {
    echo "$char -> $appeared" . PHP_EOL;
}