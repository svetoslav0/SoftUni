<?php

$people = intval(readline());
$groupType = readline();
$day = readline();
$price = 0;

switch ($groupType){
    case 'Students':
        if ($day == 'Friday'){
            $price = $people * 8.45;
        } elseif($day == 'Saturday'){
            $price = $people * 9.8;
        } elseif($day == 'Sunday'){
            $price = $people * 10.46;
        }

        if ($people >= 30){
            $price *= 0.85;
        }
        break;
    case 'Business':
        if ($people >= 100){
            $people -= 10;
        }

        if ($day == 'Friday'){
            $price = $people * 10.9;
        } elseif($day == 'Saturday'){
            $price = $people * 15.6;
        } elseif($day == 'Sunday'){
            $price = $people * 16;
        }
        break;
    case 'Regular':
        if ($day == 'Friday'){
            $price = $people * 15;
        } elseif($day == 'Saturday'){
            $price = $people * 20;
        } elseif($day == 'Sunday'){
            $price = $people * 22.5;
        }

        if ($people >= 10 && $people <= 20){
            $price *= 0.95;
        }
        break;
}

echo "Total price: " . number_format($price, 2, '.', '');