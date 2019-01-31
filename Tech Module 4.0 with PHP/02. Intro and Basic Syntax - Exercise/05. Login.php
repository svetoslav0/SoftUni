<?php

$username = readline();
$password = strrev($username);
$i = 1;

while (true){
    $currentPassword = readline();

    if ($i >= 4){
        echo "User $username blocked!";
        break;
    }

    if ($currentPassword == $password){
        echo "User $username logged in.";
        break;
    } else{
        echo 'Incorrect password. Try again.' . PHP_EOL;
        $i++;
    }
}