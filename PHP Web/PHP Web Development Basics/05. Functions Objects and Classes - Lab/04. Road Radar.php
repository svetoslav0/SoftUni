<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Oct-18
 * Time: 12:08 PM
 */

$speed = intval(readline());
$area = readline();
Radar($speed, $area);

function Radar($speed, $area){
    switch ($area){
        case 'motorway':
            $limit = 130;
            isSpeeding($limit, $speed);
            break;
        case 'interstate':
            $limit = 90;
            isSpeeding($limit, $speed);
            break;
        case 'city':
            $limit = 50;
            isSpeeding($limit, $speed);
            break;
        case 'residential':
            $limit = 20;
            isSpeeding($limit, $speed);
            break;
    }
}

function isSpeeding($limit, $speed){
    if ($speed >= $limit + 40){
        echo 'reckless driving';
    }elseif($speed >= $limit + 20){
        echo 'excessive speeding';
    }elseif($speed >= $limit){
        echo 'speeding';
    }
}