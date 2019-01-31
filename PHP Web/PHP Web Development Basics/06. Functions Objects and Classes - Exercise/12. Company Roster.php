<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 04-Oct-18
 * Time: 10:01 AM
 */

class Employee{
    public $name;
    public $salary;
    public $position;
    public $department;
    public $email = 'n/a';
    public $age = '-1';

    /**
     * Employee constructor.
     * @param $name
     * @param $salary
     * @param $position
     * @param $department
     * @param string $email
     * @param string $age
     */
    public function __construct($name, $salary, $position, $department, string $email = null, string $age = null)
    {
        $this->name = $name;
        $this->salary = $salary;
        $this->position = $position;
        $this->department = $department;
        $this->email = $email;
        $this->age = $age;
    }


    function __toString(){
        return "$this->name " . number_format($this->salary, 2, '.', '') . " $this->email $this->age" . PHP_EOL;
    }
}

$n = intval(readline());
$arr = [];

for($i = 0; $i < $n; $i++){
    $email = '';
    $age = '';
    list($name, $salary, $position, $department, $email, $age) = explode(' ', readline());
    $arr[] = new Employee($name, $salary, $position, $department, $email, $age);
}

usort($arr, function ($a, $b){
   return $a->salary <=> $b->salary;
});

foreach ($arr as $employer) {
    echo $employer;
}
