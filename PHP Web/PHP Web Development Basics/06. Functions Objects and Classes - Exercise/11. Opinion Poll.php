<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 04-Oct-18
 * Time: 9:50 AM
 */

class Person{
    public $name;
    public $age;

    function __construct($name, int $age){
        $this->name = $name;
        $this->age = $age;
    }

    function __toString(){
        return "$this->name - $this->age" . PHP_EOL;
    }
}

$arr = [];
$n = intval(readline());

for($i = 0; $i < $n; $i++){
    $line = readline();
    list($name, $age) = explode(' ', $line);
    $currentPerson = new Person($name, $age);
    if ($currentPerson->age > 30){
        $arr[] = $currentPerson;
    }
}

usort($arr, function ($a, $b){
    return $a->name <=> $b->name;
});

foreach ($arr as $currPerson) {
    echo $currPerson;
}

