<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Dec-18
 * Time: 9:08 AM
 */

class Person
{
    protected $firstName;
    protected $lastName;
    protected $email;

    public function __construct($firstName, $lastName, $email)
    {
        $this->firstName = $firstName;
        $this->lastName = $lastName;
        $this->email = $email;
    }
}