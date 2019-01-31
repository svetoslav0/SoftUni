<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Jan-19
 * Time: 2:56 PM
 */

interface Person
{
    public function setName(string $name) : void;
    public function setAge(int $age) : void;
}

interface BIdentifiable
{
    public function setId(string $id) : void;
}

interface Birthable
{
    public function setBirthdate(string $birthDate) : void;
}

class GCitizen implements Person, BIdentifiable, Birthable
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
     * @var string
     */
    private $id;

    /**
     * @var string
     */
    private $birthDate;

    /**
     * BCitizen constructor.
     * @param string $name
     * @param int $age
     * @param string $id
     * @param string $birthDate
     */
    public function __construct(string $name, int $age, string $id, string $birthDate)
    {
        $this->setName($name);
        $this->setAge($age);
        $this->setId($id);
        $this->setBirthdate($birthDate);
    }

    /**
     * @param string $name
     */
    public function setName(string $name): void
    {
        $this->name = $name;
    }

    /**
     * @param int $age
     */
    public function setAge(int $age): void
    {
        $this->age = $age;
    }

    /**
     * @param string $id
     */
    public function setId(string $id): void
    {
        $this->id = $id;
    }

    /**
     * @param string $birthDate
     */
    public function setBirthdate(string $birthDate): void
    {
        $this->birthDate = $birthDate;
    }

    /**
     * @return string
     */
    public function __toString() : string
    {
        $result = $this->name . PHP_EOL;
        $result .= $this->age . PHP_EOL;
        $result .= $this->id . PHP_EOL;
        $result .= $this->birthDate;
        return $result;
    }
}

$name = readline();
$age = intval(readline());
$id = readline();
$birthDate = readline();

$person = new GCitizen($name, $age, $id, $birthDate);
echo $person;