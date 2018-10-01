<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 5:29 PM
 */

$input = explode(', ', readline());
$assArr = [];

for($i = 0; $i < count($input); $i += 2){
    $currentTown = $input[$i];
    $currentIncome = intval($input[$i + 1]);
    if (!array_key_exists($currentTown, $assArr)){
        $assArr[$currentTown] = 0;
    }
    $assArr[$currentTown] += $currentIncome;
}

foreach ($assArr as $town => $income) {
    echo "$town => $income" . PHP_EOL;
}