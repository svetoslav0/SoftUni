<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 16-Nov-18
 * Time: 10:05 PM
 */

class Employee1 extends Human1
{
    /**
     * @var float
     */
    private $week_salary;

    /**
     * @var float
     * Work hours per day
     */
    private $work_hours;

    public function __construct(string $first_name, string $last_name, float $week_salary, float $work_hours)
    {
        parent::__construct($first_name, $last_name);
        $this->setWeekSalary($week_salary);
        $this->setWorkHours($work_hours);
    }

    /**
     * @return float
     */
    protected function getWeekSalary(): float
    {
        return $this->week_salary;
    }

    /**
     * @param float $week_salary
     * @throws Exception
     */
    protected function setWeekSalary(float $week_salary): void
    {
        if ($week_salary <= 10){
            throw new Exception('Expected value mismatch!Argument: weekSalary');
        }
        $this->week_salary = $week_salary;
    }

    /**
     * @return float
     */
    protected function getWorkHours(): float
    {
        return $this->work_hours;
    }

    /**
     * @param float $work_hours
     * @throws Exception
     */
    protected function setWorkHours(float $work_hours): void
    {
        if ($work_hours < 1 || $work_hours > 12){
            throw new Exception('Expected value mismatch!Argument: workHoursPerDay');
        }
        $this->work_hours = $work_hours;
    }

    /**
     * @param string $last_name
     * @throws Exception
     */
    protected function setLastName(string $last_name): void
    {
        if ($last_name[0] == strtolower($last_name[0])){
            throw new Exception('Expected upper case letter!Argument: lastName');
        }
        if (strlen($last_name) < 3){
            throw new Exception('Expected length more than 3 symbols!Argument: lastName');
        }
        $this->last_name = $last_name;
    }

    /**
     * @return float
     */
    protected function getSalaryPerHour() : float {
        $salary_per_day = $this->getWeekSalary() / $this->getWorkHours() / 7;
        return $salary_per_day;
    }

    public function __toString()
    {
        $result = "First Name: " . $this->getFirstName() . PHP_EOL;
        $result .= "Last Name: " . $this->getLastName() . PHP_EOL;
        $result .= "Week Salary: " . number_format($this->getWeekSalary(), 2, '.', '') . PHP_EOL;
        $result .= "Hours per day: " . number_format($this->getWorkHours(), 2, '.', '') . PHP_EOL;
        $result .= "Salary per hour: " . number_format($this->getSalaryPerHour(), 2, '.', '') . PHP_EOL;
        return $result;
    }
}