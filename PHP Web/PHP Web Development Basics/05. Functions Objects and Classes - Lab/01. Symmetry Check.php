<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 01-Oct-18
 * Time: 9:44 PM
 */

function isPalindrome($str){
    $rev_str = strrev($str);
    if ($str == $rev_str){
        echo "true";
    }else{
        echo "false";
    }
}


$input = readline();
isPalindrome($input);