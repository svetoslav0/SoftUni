<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Oct-18
 * Time: 12:29 PM
 */

class Person2{
    public $name;
    public $age;
    public function __construct(string $name, int $age) {
        $this->name = $name;
        $this->age = $age;
        echo $this->name . " " . $this->age;
    }

}
$name = readline();
$age = readline();
$person = new Person2($name, $age);
