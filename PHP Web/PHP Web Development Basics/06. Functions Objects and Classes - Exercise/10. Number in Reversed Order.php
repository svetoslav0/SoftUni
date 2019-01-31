<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 04-Oct-18
 * Time: 9:46 AM
 */

class DecimalNumber{
    public $num;
    function __construct($num){
        $this->num = $num;
    }
    function __toString(){
        return strrev($this->num);
    }
}

$num = new DecimalNumber(readline());
echo $num;