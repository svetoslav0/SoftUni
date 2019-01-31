<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Jan-19
 * Time: 10:41 AM
 */

class Rebel implements INameable, IGroupable, IAgeable
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
    private $group;

    /**
     * Rebel constructor.
     * @param string $name
     * @param int $age
     * @param string $group
     */
    public function __construct(string $name, int $age, string $group)
    {
        $this->setName($name);
        $this->setAge($age);
        $this->setGroup($group);
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
     * @param string $group
     */
    public function setGroup(string $group): void
    {
        $this->group = $group;
    }
}