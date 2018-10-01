<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Sep-18
 * Time: 7:07 PM
 */

$counter = [];
$input = explode('|', readline());
while ($input[0] != 'Result'){
    $team = '';
    $player = '';
    $points = $input[2];
    if (strtoupper($input[0]) == $input[0]){
        $team = $input[0];
        $player = $input[1];
    }else{
        $team = $input[1];
        $player = $input[0];
    }
    $team = str_replace(['@', '%', '&', '$', '*'], '', $team);
    $player = str_replace(['@', '%', '&', '$', '*'], '', $player);
    if ()
    $counter[$team][] = [$player, $points];


    $input = explode('|', readline());
}
var_dump($counter);

// NOT FINISHED!