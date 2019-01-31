<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 01-Oct-18
 * Time: 9:48 PM
 */

DayToNum(readline());

function DayToNum($day){
    switch ($day){
        case "Monday":
            echo 1;
            break;
        case "Tuesday":
            echo 2;
            break;
        case "Wednesday":
            echo 3;
            break;
        case "Thursday":
            echo 4;
            break;
        case "Friday":
            echo 5;
            break;
        case "Saturday":
            echo 6;
            break;
        case "Sunday":
            echo 7;
            break;
        default:
            echo "Invalid day!";
            break;
    }
}