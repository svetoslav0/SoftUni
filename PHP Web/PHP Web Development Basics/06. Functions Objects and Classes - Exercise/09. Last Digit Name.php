<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 04-Oct-18
 * Time: 9:28 AM
 */

class Number{
    public $num;

    function  __construct($num){
        $this->num = $num;
    }
    function LastDigitToWord(){
        $digit =  intval($this->num % 10);
        switch ($digit){
            case 0:
                echo 'zero';
                break;
            case 1:
                echo 'one';
                break;
            case 2:
                echo 'two';
                break;
            case 3:
                echo 'three';
                break;
            case 4:
                echo 'four';
                break;
            case 5:
                echo 'five';
                break;
            case 6:
                echo 'six';
                break;
            case 7:
                echo 'seven';
                break;
            case 8:
                echo 'eight';
                break;
            case 9:
                echo 'nine';
                break;
        }
    }
}

$number = new Number(readline());
$number->LastDigitToWord();
