<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Dec-18
 * Time: 9:10 AM
 */

class Student extends Person
{
    public function printData(){
        $result = 'First name: ' . $this->firstName . "\n";
        $result .= 'Email: ' . $this->email . "\n\n";
        return $result;
    }
}