<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 16-Nov-18
 * Time: 10:01 PM
 */

class Student1 extends Human1
{
    /**
     * @var string
     */
    private $faculty_number;

    /**
     * Student constructor.
     * @param string $first_name
     * @param string $last_name
     * @param string $faculty_number
     * @throws Exception
     */
    public function __construct(string $first_name, string $last_name, string $faculty_number)
    {
        parent::__construct($first_name, $last_name);
        $this->setFacultyNumber($faculty_number);
    }

    /**
     * @return string
     */
    protected function getFacultyNumber(): string
    {
        return $this->faculty_number;
    }

    /**
     * @param string $faculty_number
     * @throws Exception
     */
    protected function setFacultyNumber(string $faculty_number): void
    {
        if (strlen($faculty_number) < 5 || strlen($faculty_number) > 10 || !is_numeric($faculty_number)){
            throw new Exception('Invalid faculty number!');
        }
        $this->faculty_number = $faculty_number;
    }

    public function __toString()
    {
        $result = 'First Name: ' . $this->getFirstName() . PHP_EOL;
        $result .= "Last Name: " . $this->getLastName() . PHP_EOL;
        $result .= 'Faculty number: ' . $this->getFacultyNumber() . PHP_EOL;
        return $result;
    }
}