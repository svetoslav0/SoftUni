<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 6:48 PM
 */

$input = explode(' ', readline());
$phonebook = [];

while($input[0] != 'END'){
    $command = $input[0];
    $name = $input[1];
    switch ($command){
        case 'A':
            $number = $input[2];
            if (!array_key_exists($name, $phonebook)){
                $phonebook[$name] = "";
            }
            $phonebook[$name] = $number;
            break;
        case 'S':
            if (array_key_exists($name, $phonebook)){
                echo $name . ' -> ' . $phonebook[$name] . PHP_EOL;
            }else{
                echo "Contact $name does not exist." . PHP_EOL;
            }

            break;
    }

    $input = explode(' ', readline());
}