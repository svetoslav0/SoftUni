<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Jan-19
 * Time: 2:23 PM
 */

class DCitizen implements Person
{

    /**
     * @var string
     */
    private $name;

    /**
     * @var int
     */
    private $age;

    /**
     * BCitizen constructor.
     * @param string $name
     * @param int $age
     */
    public function __construct(string $name, int $age)
    {
        $this->setName($name);
        $this->setAge($age);
    }

    /**
     * @param string $name
     * @return void
     */
    public function setName(string $name) : void
    {
        $this->name = $name;
    }

    /**
     * @param int $age
     * @return void
     */
    public function setAge(int $age) : void
    {
        $this->age = $age;
    }

    /**
     * @return string
     */
    public function __toString() : string
    {
        return $this->name . PHP_EOL . $this->age;
    }
}