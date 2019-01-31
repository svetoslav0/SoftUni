<?php

$num = intval(readline());

if ($num >= 0 && $num <= 2){
    echo 'baby';
} elseif($num <= 13){
    echo 'child';
} elseif($num <= 19){
    echo 'teenager';
} elseif($num <= 65){
    echo 'adult';
} elseif($num > 65){
    echo 'elder';
}