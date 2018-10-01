<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 4:53 PM
 */

$arr = explode(' ', readline());

$assArr = [];

for($i = 0; $i < count($arr); $i++){
    $current = $arr[$i];
    if (!array_key_exists($current, $assArr)){
        $assArr[$current] = 0;
    }
    $assArr[$current]++;
}

ksort($assArr);

foreach ($assArr as $key => $value) {
    echo "$key -> $value" . PHP_EOL;
}