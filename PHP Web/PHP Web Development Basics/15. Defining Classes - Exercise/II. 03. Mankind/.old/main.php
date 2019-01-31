<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 16-Nov-18
 * Time: 10:19 PM
 */

spl_autoload_register();

list($student_first_name, $student_last_name, $faculty_number) = explode(' ', readline());
list($employee_first_name, $employee_last_name, $salary, $working_hours) = explode(' ', readline());

try{
    $s = new Student1($student_first_name, $student_last_name, $faculty_number);
    echo $s . PHP_EOL;
}catch (Exception $exception){
    die($exception->getMessage());
}

try{
    $e = new Employee1($employee_first_name, $employee_last_name, $salary, $working_hours);
    echo $e;
}catch (Exception $exception){
    die($exception->getMessage());
}
