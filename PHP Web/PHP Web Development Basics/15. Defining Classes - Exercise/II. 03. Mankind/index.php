<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Dec-18
 * Time: 12:13 PM
 */
spl_autoload_register();

list($studentFirstName, $studentLastName, $facultyNumber) = explode(' ', readline());
list($workerFirstName, $workerLastName, $weekSalary, $workingHours) = explode(' ', readline());
$weekSalary = floatval($weekSalary);
$workingHours = floatval($workingHours);

try{
    $student = new Student($studentFirstName, $studentLastName, $facultyNumber);
    $worker = new Jobber($workerFirstName, $workerLastName, $weekSalary, $workingHours);
    echo $student;
    echo $worker;
}catch (Exception $e){
    echo $e->getMessage();
}
