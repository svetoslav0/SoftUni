<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 14-Nov-18
 * Time: 12:11 PM
 */

class Vehicle3{

    /**
     * @var int
     */
    private $numberDoors;
    /**
     * @var string
     */
    private $color;

    /**
     * Vehicle3 constructor.
     * @param int $numberDoors
     * @param string $color
     */
    public function __construct(int $numberDoors, string $color)
    {
        $this->setNumberDoors($numberDoors);
        $this->setColor($color);
    }

    /**
     * @return int
     */
    public function getNumberDoors(): int
    {
        return $this->numberDoors;
    }

    /**
     * @param int $numberDoors
     */
    public function setNumberDoors(int $numberDoors): void
    {
        $this->numberDoors = $numberDoors;
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
    private function setColor(string $color): void
    {
        $this->color = $color;
    }

    public function Paint(string $color):void
    {
        $this->setColor($color);
    }
}

$vehicle = new Vehicle3(4, 'orange');
$vehicle->Paint('blue');
var_dump($vehicle);