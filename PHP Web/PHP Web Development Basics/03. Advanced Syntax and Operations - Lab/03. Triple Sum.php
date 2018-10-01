<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 28-Sep-18
 * Time: 6:51 PM
 */

$array = array_map('intval', explode(' ', readline()));
$found = false;

$length = count($array);

for($i = 0; $i < $length; $i++){
    for($j = $i; $j < $length; $j++){
        if ($i != $j){
            $sum = $array[$i] + $array[$j];
            if (in_array($sum, $array)){
                $found = true;
                echo "$array[$i] + $array[$j] == $sum" . PHP_EOL;
            }
        }
    }
}

if (!$found){
    echo "No";
}
