<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Jan-19
 * Time: 10:32 PM
 */

interface IArchangel
{
    public function getEnergy() : float;
    public function setEnergy(float $energy) : void;
}