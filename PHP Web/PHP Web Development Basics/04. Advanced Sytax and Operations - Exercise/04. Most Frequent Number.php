<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 27-Sep-18
 * Time: 2:28 PM
 */

// 4 1 1 4 2 3 4 4 1 2 4 9 3 -> 4 (5 times)

$nums = explode(' ', readline());

$occurs = [];

for ($i = 0; $i < count($nums); $i++){
    $occurs[$nums[$i]]++;
}

arsort($occurs);

echo key($occurs);

