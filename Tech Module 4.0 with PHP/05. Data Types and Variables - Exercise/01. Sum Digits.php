<?php

$number = readline();
$result = 0;

for($i = 0; $i < strlen($number); $i++){
    $result += intval($number[$i]);
}

echo $result;