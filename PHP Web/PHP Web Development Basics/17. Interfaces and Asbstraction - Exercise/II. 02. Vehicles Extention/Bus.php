<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Dec-18
 * Time: 12:14 PM
 */

class Bus extends Vehicle
{
    public function driveEmpty(float $distance){
        $range = $this->getFuel() / $this->consumption;
        if ($distance > $range){
            $this->last_status = get_called_class() . ' needs refueling' . PHP_EOL;
            return false;
        }
        $this->last_status = get_called_class() . ' travelled ' . $distance . ' km' . PHP_EOL;
        $this->fuel -= $distance * $this->getConsumption();
        return true;
    }

    function getConsumption()
    {
        return $this->consumption + 1.4;
    }
}