<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 7:04 PM
 */

$people = (int)readline();
$package = readline();
$totalSum = 0;
$hall = "";


if ($people <= 50){
    $totalSum = 2500;
    $hall = "Small Hall";
}else if($people <= 100){
    $totalSum = 5000;
    $hall = "Terrace";
}else if ($people <= 120){
    $totalSum = 7500;
    $hall = "Great Hall";
}else{
    echo "We do not have an appropriate hall.";
    return;
}


switch ($package){
    case "Normal":
        $totalSum += 500;
        $totalSum *= 0.95;
        break;
    case "Gold":
        $totalSum += 750;
        $totalSum *= 0.9;
        break;
    case "Platinum":
        $totalSum += 1000;
        $totalSum *= 0.85;
}
$pricePerPerson = number_format($totalSum / $people, 2, ".", "");

echo "We can offer you the $hall\r\n";
echo "The price per person is $pricePerPerson$";

