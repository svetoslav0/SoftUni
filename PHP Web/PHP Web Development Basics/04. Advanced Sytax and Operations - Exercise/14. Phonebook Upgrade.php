<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 6:55 PM
 */

$input = explode(' ', readline());
$phonebook = [];

while($input[0] != 'END'){
    $command = $input[0];
    switch ($command){
        case 'A':
            $name = $input[1];
            $number = $input[2];
            if (!array_key_exists($name, $phonebook)){
                $phonebook[$name] = "";
            }
            $phonebook[$name] = $number;
            break;
        case 'S':
            $name = $input[1];
            if (array_key_exists($name, $phonebook)){
                echo $name . ' -> ' . $phonebook[$name] . PHP_EOL;
            }else{
                echo "Contact $name does not exist." . PHP_EOL;
            }

            break;
        case 'ListAll':
            ksort($phonebook);
            foreach ($phonebook as $name => $number) {
                echo "$name -> $number" . PHP_EOL;
            }
            break;
    }

    $input = explode(' ', readline());
}