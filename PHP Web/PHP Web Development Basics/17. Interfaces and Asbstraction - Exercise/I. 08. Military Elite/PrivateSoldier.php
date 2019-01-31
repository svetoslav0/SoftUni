<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Jan-19
 * Time: 5:17 PM
 */

class PrivateSoldier extends Soldier implements IPrivateSoldier
{
    /**
     * @var float
     */
    protected $salary;

    /**
     * PrivateSoldier constructor.
     * @param array $data
     */
    public function __construct(array $data)
    {
        $this->id = $data[1];
        $this->firstName = $data[2];
        $this->lastName = $data[3];
        $this->salary = $data[4];
    }

    /**
     * @return float
     */
    public function getSalary(): float
    {
        return $this->salary;
    }

    /**
     * @param float $salary
     */
    public function setSalary(float $salary): void
    {
        $this->salary = $salary;
    }

    /**
     * @return string
     */
    public function __toString()
    {
        $result = 'Name: ' . $this->getFirstName() . ' ' . $this->getLastName();
        $result .= ' Id: ' . $this->getId();
        $result .= ' Salary: ' . number_format($this->getSalary(), 2, '.', '') . PHP_EOL;
        return $result;
    }
}