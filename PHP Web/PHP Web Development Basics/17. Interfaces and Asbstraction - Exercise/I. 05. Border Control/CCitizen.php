<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 05-Jan-19
 * Time: 3:38 PM
 */

class CCitizen extends Identifiable
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
     * @param string $id
     */
    public function __construct(string $name, int $age, string $id)
    {
        $this->setName($name);
        $this->setAge($age);
        $this->setId($id);
    }

    /**
     * @return string
     */
    public function getName(): string
    {
        return $this->name;
    }

    /**
     * @param string $name
     */
    public function setName(string $name): void
    {
        $this->name = $name;
    }

    /**
     * @return int
     */
    public function getAge(): int
    {
        return $this->age;
    }

    /**
     * @param int $age
     */
    public function setAge(int $age): void
    {
        $this->age = $age;
    }
}