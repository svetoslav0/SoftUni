<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Dec-18
 * Time: 9:11 AM
 */

class Teacher extends Person
{
    public function printData(){
        $result = 'Last name: ' . $this->lastName . "\n";
        $result .= 'Email: ' . $this->email . "\n\n";
        return $result;
    }
}