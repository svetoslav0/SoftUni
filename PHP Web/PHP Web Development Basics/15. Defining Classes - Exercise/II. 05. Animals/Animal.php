<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 17-Nov-18
 * Time: 10:10 AM
 */

class Animal
{
    /**
     * @var string
     */
    protected $name;

    /**
     * @var float
     */
    protected $age;

    /**
     * @var string
     */
    protected $gender;

    /**
     * Animal constructor.
     * @param string $name
     * @param float $age
     * @param string $gender
     * @throws Exception
     */
    public function __construct(string $name, float $age, string $gender)
    {
        $this->setName($name);
        $this->setAge($age);
        $this->setGender($gender);
    }


    /**
     * @return string
     */
    protected function getName(): string
    {
        return $this->name;
    }

    /**
     * @param string $name
     * @throws Exception
     */
    protected function setName(string $name): void
    {
        if ($name == ''){
            throw new Exception('Invalid input!');
        }
        $this->name = $name;
    }

    /**
     * @return float
     */
    protected function getAge(): float
    {
        return $this->age;
    }

    /**
     * @param float $age
     * @throws Exception
     */
    protected function setAge(float $age): void
    {
        if ($age < 0){
            throw new Exception('Invalid input!');
        }
        $this->age = $age;
    }

    /**
     * @return string
     */
    protected function getGender(): string
    {
        return $this->gender;
    }

    /**
     * @param string $gender
     * @throws Exception
     */
    protected function setGender(string $gender): void
    {
        if ($gender == ''){
            throw new Exception('Invalid input!');
        }
        $this->gender = $gender;
    }

    public function __toString()
    {
        return get_called_class() . ' ' . $this->getName() . ' ' . $this->getAge() . ' ' . $this->getGender() . PHP_EOL;
    }

    public function produceSound(){
        echo 'Not implemented!';
    }

}