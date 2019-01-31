<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 15-Nov-18
 * Time: 7:06 PM
 */

$points = 0;
$line = explode(',', readline());

foreach ($line as $currentFood) {
    switch (strtolower($currentFood)){
        case 'cram':
            $points += 2;
            break;
        case 'lembas':
            $points += 3;
            break;
        case 'apple':
        case 'melon':
            $points += 1;
            break;
        case 'honeycake':
            $points += 5;
            break;
        case 'mushrooms':
            $points -= 10;
            break;
        default:
            $points -= 1;
            break;
    }
}
echo $points . PHP_EOL;

if ($points < -5){
    echo 'Angry';
}elseif($points < 0){
    echo 'Sad';
}elseif($points <= 15){
    echo 'Happy';
}else{
    echo 'PHP';
}