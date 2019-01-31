<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Oct-18
 * Time: 7:30 PM
 */

class Person4{
    public $name;

    function __construct($name){
        $this->name = $name;
    }

    function __toString(){
        return "$this->name says \"Hello\"!";
    }
}

$person = new Person4(readline());
echo $person;