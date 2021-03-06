<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Oct-18
 * Time: 12:32 PM
 */

class Person3{
    public $name;
    public $age;
    public $occupation;
    function __construct(string $name, int $age, string $occupation){
        $this->name = $name;
        $this->age = $age;
        $this->occupation = $occupation;
    }

    function __toString()
    {
        return "$this->name - age: $this->age, occupation: $this->occupation" . PHP_EOL;
    }

}

$arr = [];
while (1){
    $line = readline();
    if($line == "END"){break;}
    list($name, $age, $occupation) = explode(' ', $line);
    $currentPerson = new Person3($name, $age, $occupation);
    array_push($arr, $currentPerson);
}

usort($arr, function($a, $b)
{
    return $a->age <=> $b->age;
});

foreach ($arr as $person) {
    echo $person;
}