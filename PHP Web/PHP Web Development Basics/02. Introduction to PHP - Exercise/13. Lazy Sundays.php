<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 9:44 PM
 */

$month = readline();
$monthNum = 0;
switch ($month){
    case "January":
        $month = 1;
        break;
    case "February":
        $month = 2;
        break;
    case "March":
        $month = 3;
        break;
    case "April":
        $month = 4;
        break;
    case "May":
        $month = 5;
        break;
    case "June":
        $month = 6;
        break;
    case "July":
        $month = 7;
        break;
    case "August":
        $month = 8;
        break;
    case "September":
        $month = 9;
        break;
    case "October":
        $month = 10;
        break;
    case "November":
        $month = 11;
        break;
    case "December":
        $month = 12;
        break;
}

$daysOfMonth = date("t", mktime(0, 0, 0, $month, 1, 2018));

for ($i = 1; $i <= $daysOfMonth; $i++){
    $dayOfTheWeek = date("l", mktime(0, 0, 0, $month, $i, 2018));
    if ($dayOfTheWeek == "Sunday"){
        $outputDate = date("jS m\, Y", mktime(0, 0, 0, $month, $i, 2018));
        echo $outputDate . PHP_EOL;
        $i += 6;
    }
}