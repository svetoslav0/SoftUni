<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 6:22 PM
 */

$arr = explode(" ", readline());
foreach ($arr as $word) {
    $len = strlen($word);
    for ($i = 0; $i < $len; $i++){
        echo $word;
    }
}
