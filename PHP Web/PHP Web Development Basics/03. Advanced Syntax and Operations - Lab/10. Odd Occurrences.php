<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 5:05 PM
 */

$input = strtolower(readline());
$line = explode(' ', $input);

$assArr = [];
for($i = 0; $i < count($line); $i++){
    if (!array_key_exists($line[$i], $assArr)){
        $assArr[$line[$i]] = 0;
    }
    $assArr[$line[$i]]++;
}

$result = [];
foreach ($assArr as $word => $appeared) {
    if ($appeared % 2 != 0){
        array_push($result, $word);
    }
}
echo implode(', ', $result);