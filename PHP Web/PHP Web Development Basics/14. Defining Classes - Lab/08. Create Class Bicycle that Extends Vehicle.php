<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 14-Nov-18
 * Time: 1:00 PM
 */

include '07. Protecting the Number of Doors Setter.php';

class Bicycle extends Vehicle4 {

    /**
     * @var bool
     */
    public $forSkirt;

    public function __construct(bool $forSkirt, string $color, int $numberDoors = 0)
    {
        parent::__construct($numberDoors, $color);
        $this->setForSkirt($forSkirt);
    }

    /**
     * @return bool
     */
    public function isForSkirt(): bool
    {
        return $this->forSkirt;
    }

    /**
     * @param bool $forSkirt
     */
    private function setForSkirt(bool $forSkirt): void
    {
        $this->forSkirt = $forSkirt;
    }

    /**
     *  Ride() Method
     */
    public function Ride(){

    }

    /**
     * Stop() Method
     */
    public function Stop(){

    }
}

$bike = new Bicycle('yes', 'green');
echo $bike->getNumberDoors();