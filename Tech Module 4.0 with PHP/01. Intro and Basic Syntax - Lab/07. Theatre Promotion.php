<?php

$dayType = readline();
$age = intval(readline());

switch ($dayType){
    case 'Weekday':
        if ($age >= 0 && $age <= 18){
            echo '12$';
        } elseif($age > 18 && $age <= 64){
            echo '18$';
        } elseif($age > 64 && $age <= 122){
            echo '12$';
        } else{
            echo 'Error!';
        }
        break;
    case 'Weekend':
        if ($age >= 0 && $age <= 18){
            echo '15$';
        } elseif($age > 18 && $age <= 64){
            echo '20$';
        } elseif($age > 64 && $age <= 122){
            echo '15$';
        } else{
            echo 'Error!';
        }
        break;
    case 'Holiday':
        if ($age >= 0 && $age <= 18){
            echo '5$';
        } elseif($age > 18 && $age <= 64){
            echo '12$';
        } elseif($age > 64 && $age <= 122){
            echo '10$';
        } else{
            echo 'Error!';
        }
        break;
}