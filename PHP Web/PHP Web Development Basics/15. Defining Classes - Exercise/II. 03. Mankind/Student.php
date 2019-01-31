<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Dec-18
 * Time: 12:13 PM
 */

class Student extends Human
{
    /**
     * @var string
     */
    protected $facultyNumber;

    /**
     * Student constructor.
     * @param string $firstName
     * @param string $lastName
     * @param string $facultyNumber
     * @throws Exception
     */
    public function __construct(string $firstName, string $lastName, string $facultyNumber)
    {
        parent::__construct($firstName, $lastName);
        $this->setFacultyNumber($facultyNumber);
    }

    /**
     * @param string $facultyNumber
     * @throws Exception
     */
    public function setFacultyNumber($facultyNumber) : void
    {
        if (strlen($facultyNumber) < 5 || strlen($facultyNumber) > 10){
            throw new Exception('Invalid faculty number!');
        }
        $this->facultyNumber = $facultyNumber;
    }

    /**
     * @return string
     */
    public function getFacultyNumber(): string
    {
        return $this->facultyNumber;
    }

    public function __toString()
    {
        $result = 'First Name: ' . $this->getFirstName() . PHP_EOL;
        $result .= 'Last Name: ' . $this->getLastName() . PHP_EOL;
        $result .= 'Faculty number: ' . $this->getFacultyNumber() . PHP_EOL . PHP_EOL;

        return $result;
    }
}