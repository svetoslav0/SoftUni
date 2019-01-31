<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Dec-18
 * Time: 11:55 AM
 */

class Truck extends Vehicle
{
    public function refuel(float $fuel){
        $this->fuel += $fuel;
        if ($this->fuel > $this->capacity){
            $this->fuel = $this->capacity;
            $this->getFuel();
        }
        $this->last_status = '';
    }

    function getConsumption()
    {
        return $this->consumption + 1.6;
    }

    public function getFuel()
    {
        return $this->fuel * 0.95;
    }
}