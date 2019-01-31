<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Oct-18
 * Time: 12:27 PM
 */

class Person{
    public $name;
    public $age;
}

$person = new Person();
echo(count(get_object_vars($person)));
