<?php

$num1 = doubleval(readline());
$num2 = doubleval(readline());
$diff = abs($num1 - $num2);

if ($diff <= 0.000001){
    echo 'True';
    return;
}
echo 'False';