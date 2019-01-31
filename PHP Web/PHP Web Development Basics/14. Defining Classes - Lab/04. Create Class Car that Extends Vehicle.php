<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 14-Nov-18
 * Time: 12:15 PM
 */

class Car extends Vehicle3{
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
    public function setModel(string $model): void
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
    public function setYear(int $year): void
    {
        $this->year = $year;
    }
}

$car = new Car(4,'Red', 'Audi', 'A4', 2016);

var_dump($car);