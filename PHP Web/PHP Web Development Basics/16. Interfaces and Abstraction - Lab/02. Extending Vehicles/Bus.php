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

    }

    function getConsumption()
    {
        return $this->consumption * 1.4;
    }
}