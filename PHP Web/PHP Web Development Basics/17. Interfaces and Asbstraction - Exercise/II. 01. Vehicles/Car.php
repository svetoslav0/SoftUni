<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Dec-18
 * Time: 11:55 AM
 */

class Car extends Vehicle
{
    function getConsumption()
    {
        return $this->consumption + 0.9;
    }
}