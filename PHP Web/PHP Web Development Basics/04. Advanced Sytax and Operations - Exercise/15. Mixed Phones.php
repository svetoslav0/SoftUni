<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 6:58 PM
 */

$input = explode(' : ', readline());
$phonebook = [];
while($input[0] != 'Over'){
    $elementOne = $input[0];
    $elementTwo = $input[1];
    $phone = is_numeric($elementOne) ? $elementOne : $elementTwo;
    $name = $phone == $elementOne ? $elementTwo : $elementOne;
    if (!array_key_exists($name, $phonebook)){
        $phonebook[$name] = "";
    }
    $phonebook[$name] = $phone;
    $input = explode(' : ', readline());
}

ksort($phonebook);
foreach ($phonebook as $name => $phone) {
    echo "$name -> $phone" . PHP_EOL;
}