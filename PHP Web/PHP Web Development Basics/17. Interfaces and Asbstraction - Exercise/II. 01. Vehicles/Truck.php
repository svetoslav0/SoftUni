<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Dec-18
 * Time: 11:55 AM
 */

class Truck extends Vehicle
{
    function getConsumption()
    {
        return $this->consumption + 1.6;
    }

    public function refuel(float $fuel)
    {
        $this->last_status = '';
        $this->fuel += $fuel * 0.95;
    }
}