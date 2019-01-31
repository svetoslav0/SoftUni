<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 14-Nov-18
 * Time: 12:06 PM
 */

class Vehicle2{

    /**
     * @var int
     */
    private $numberDoor;

    /**
     * @var string
     */
    private $color;

    /**
     * Vehicle2 constructor.
     * @param int $numberDoor
     * @param string $color
     */
    public function __construct(int $numberDoor, string $color)
    {
        $this->setNumberDoor($numberDoor);
        $this->setColor($color);
    }

    /**
     * @return int
     */


    public function getNumberDoor(): int
    {
        return $this->numberDoor;
    }

    /**
     * @param int $numberDoor
     */
    public function setNumberDoor(int $numberDoor): void
    {
        $this->numberDoor = $numberDoor;
    }

    /**
     * @return string
     */
    public function getColor(): string
    {
        return $this->color;
    }

    /**
     * @param string $color
     */
    public function setColor(string $color): void
    {
        $this->color = $color;
    }

    public function __get($name)
    {
        echo "Property doesn't exists";
    }
}

$vehicle = new Vehicle2(4, 'green');
echo $vehicle->model;