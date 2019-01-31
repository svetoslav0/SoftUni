<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Dec-18
 * Time: 11:54 AM
 */

abstract class Vehicle
{
    /**
     * @var float
     */
    protected $fuel;

    /**
     * @var float
     */
    protected $consumption;

    /**
     * @var string
     */
    protected $last_status;

    /**
     * @var float
     */
    protected $capacity;

    /**
     * Vehicle constructor.
     * @param float $fuel
     * @param float $consumption
     * @param float $capacity
     */
    public function __construct(float $fuel, float $consumption, float $capacity)
    {
        $this->fuel = $fuel;
        $this->consumption = $consumption;
        $this->capacity = $capacity;
    }

    public function drive(float $distance){
        if ($distance < 0){
            throw new Exception('Distance must be a positive number' . PHP_EOL);
        }
        $range = $this->getFuel() / $this->getConsumption(); // 40 /
        if ($distance > $range){
            $this->last_status = get_called_class() . ' needs refueling' . PHP_EOL;
            return false;
        }
        $this->last_status = get_called_class() . ' travelled ' . $distance . ' km' . PHP_EOL;
        $this->fuel -= $distance * $this->getConsumption();
        return true;
    }


    public function refuel(float $fuel){
        if ($this->getFuel() + $fuel > $this->capacity){
            throw new Exception('Cannot fit fuel in tank' . PHP_EOL);
        }
        $this->fuel += $fuel;
        $this->last_status = '';
    }

    /**
     * @return mixed
     */
    public function getLastStatus()
    {
        return $this->last_status;
    }

    abstract function getConsumption();

    public function getFuel()
    {
        return $this->fuel;
    }
}