<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 14-Nov-18
 * Time: 12:01 PM
 */

class Vehicle{
    /**
     * @var int
     */
    private $numberDoors;

    /**
     * @var string
     */
    private $color;

    /**
     * Vehicle constructor.
     * @param int $numberDoors
     * @param string $color
     */
    public function __construct(int $numberDoors, string $color)
    {
        $this->numberDoors = $numberDoors;
        $this->color = $color;
    }
}

$car = new Vehicle(2, 'orange');