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

    protected $last_status;

    /**
     * Vehicle constructor.
     * @param float $fuel
     * @param float $consumption
     */
    public function __construct(float $fuel, float $consumption)
    {
        $this->fuel = $fuel;
        $this->consumption = $consumption;
    }

    public function drive(float $distance){
        $range = $this->getFuel() / $this->getConsumption();
        if ($distance > $range){
            $this->last_status = get_called_class() . ' needs refueling' . PHP_EOL;
            return false;
        }
        $this->last_status = get_called_class() . ' travelled ' . $distance . ' km' . PHP_EOL;
        $this->fuel -= $distance * $this->getConsumption();
        return true;
    }


    public function refuel(float $fuel){
        $this->last_status = '';
        $this->fuel += $fuel;
        //$this->last_status = $this->getFuel() + $fuel;
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