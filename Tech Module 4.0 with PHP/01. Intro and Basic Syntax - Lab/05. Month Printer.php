<?php

$num = intval(readline());

$months = [
    1 => 'January',
    2 => 'February',
    3 => 'March',
    4 => 'April',
    5 => 'May',
    6 => 'June',
    7 => 'July',
    8 => 'August',
    9 => 'september',
    10 => 'October',
    11 => 'November',
    12 => 'December',
];

if (array_key_exists($num, $months)){
    echo $months[$num];
} else{
    echo 'Error!';
}