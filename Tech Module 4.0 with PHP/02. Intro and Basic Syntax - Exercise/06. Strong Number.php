<?php

$num = readline();
$sum = 0;

for($i = 0; $i < strlen($num); $i++){
    $sum += Factorial(intval($num[$i]));
}

if($sum == intval($num)){
    echo 'yes';
}else{
    echo 'no';
}

function Factorial($num){
    if($num <= 1){
        return 1;
    }
    else{
        return $num * Factorial($num - 1);
    }
}

