<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 14-Nov-18
 * Time: 12:56 PM
 */


class Vehicle4{

    /**
     * @var int
     */
    protected $numberDoors = 0;
    /**
     * @var string
     */
    protected $color;

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
    protected function setNumberDoors(int $numberDoors): void
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
    protected function setColor(string $color): void
    {
        $this->color = $color;
    }

    public function Paint(string $color):void
    {
        $this->setColor($color);
    }
}

class Car4 extends Vehicle4 {

    /**
     * @var string
     */
    public $color;
    /**
     * @var string
     */
    private $brand;
    /**
     * @var string
     */
    private $model;
    /**
     * @var int
     */
    private $year;

    /**
     * Car constructor.
     * @param int $numberDoors
     * @param string $color
     * @param string $brand
     * @param string $model
     * @param int $year
     */
    public function __construct(int $numberDoors, string $color, string $brand, string $model, int $year)
    {
        parent::__construct($numberDoors, $color);
        $this->setBrand($brand);
        $this->setModel($model);
        $this->setYear($year);
    }

    /**
     * @return string
     */
    public function getBrand(): string
    {
        return $this->brand;
    }

    /**
     * @param string $brand
     */
    public function setBrand(string $brand): void
    {
        $this->brand = $brand;
    }

    /**
     * @return string
     */
    public function getModel(): string
    {
        return $this->model;
    }

    /**
     * @param string $model
     */
    private function setModel(string $model): void
    {
        $this->model = $model;
    }

    /**
     * @return int
     */
    public function getYear(): int
    {
        return $this->year;
    }

    /**
     * @param int $year
     */
    private function setYear(int $year): void
    {
        $this->year = $year;
    }
}

$vehicle = new Vehicle4(4, 'orange');
$vehicle->Paint('blue');
//$vehicle->setNumberDoors(2);