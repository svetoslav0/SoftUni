<?php

$digits = [
    0 => 'zero',
    1 => 'one',
    2 => 'two',
    3 => 'three',
    4 => 'four',
    5 => 'five',
    6 => 'six',
    7 => 'seven',
    8 => 'eight',
    9 => 'nine'
];

$number = intval(readline());
$lastDigit = $number % 10;
echo $digits[$lastDigit];