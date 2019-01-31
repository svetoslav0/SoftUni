<?php

$money = doubleval(readline());
$students = intval(readline());
$lightSabersPrice = doubleval(readline());
$robesPrice = doubleval(readline());
$beltsPrice = doubleval(readline());

$totalLightSabers = ceil($students * 1.1);
$totalBelts = $students - floor($students / 6);
$totalRobes = $students;

$totalPrice = $totalLightSabers * $lightSabersPrice + $totalRobes * $robesPrice + $totalBelts * $beltsPrice;

if ($totalPrice > $money){
    $neededMoney = number_format($totalPrice - $money, 2, '.', '');
    echo "Ivan Cho will need {$neededMoney}lv more.";
} else {
    $totalPrice = number_format($totalPrice, 2, '.', '');
    echo "The money is enough - it would cost {$totalPrice}lv.";
}