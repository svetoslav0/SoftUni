<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Dec-18
 * Time: 12:17 PM
 */

class Jobber extends Human
{
    /**
     * @var float
     */
    protected $weekSalary;

    /**
     * @var float
     */
    protected $workHours;

    /**
     * Jobber constructor.
     * @param string $firstName
     * @param string $lastName
     * @param float $weekSalary
     * @param float $workHours
     * @throws Exception
     */
    public function __construct(string $firstName, string $lastName, float $weekSalary, float $workHours)
    {
        parent::__construct($firstName, $lastName);
        $this->setWeekSalary($weekSalary);
        $this->setWorkHours($workHours);
    }

    /**
     * @param string $lastName
     * @throws Exception
     */
    public function setLastName(string $lastName): void
    {
        if (strlen($lastName) < 3){
            throw new Exception('Expected length more than 3 symbols!Argument: lastName');
        }
        $this->lastName = $lastName;
    }

    /**
     * @param float $weekSalary
     * @throws Exception
     */
    public function setWeekSalary($weekSalary) : void
    {
        if ($weekSalary < 10){
            throw new Exception('Expected value mismatch!Argument: weekSalary');
        }
        $this->weekSalary = $weekSalary;
    }

    /**
     * @return float
     */
    public function getWeekSalary() : float
    {
        return $this->weekSalary;
    }

    /**
     * @param float $workHours
     * @throws Exception
     */
    public function setWorkHours($workHours) : void
    {
        if ($workHours < 1 || $workHours > 12){
            throw new Exception('Expected value mismatch!Argument: workHoursPerDay');
        }
        $this->workHours = $workHours;
    }

    /**
     * @return float
     */
    public function getWorkHours() : float
    {
        return $this->workHours;
    }

    /**
     * @return float
     */
    public function getSalaryPerHour() : float
    {
        return $this->getWeekSalary() / $this->getWorkHours() / 7.0;
    }

    /**
     * @param $number
     * @return string
     */
    private function secondDigitFormat($number) : string
    {
        return number_format($number, 2, '.', '');
    }

    /**
     * @return string
     */
    public function __toString()
    {
        $result = 'First Name: ' . $this->getFirstName() . PHP_EOL;
        $result .= 'Last Name: ' . $this->getLastName() . PHP_EOL;
        $result .= 'Week Salary: ' . $this->secondDigitFormat($this->getWeekSalary()) . PHP_EOL;
        $result .= 'Hours per day: ' . $this->secondDigitFormat($this->getWorkHours()) . PHP_EOL;
        $result .= 'Salary per hour: ' . $this->secondDigitFormat($this->getSalaryPerHour()) . PHP_EOL;
        return $result;
    }

}