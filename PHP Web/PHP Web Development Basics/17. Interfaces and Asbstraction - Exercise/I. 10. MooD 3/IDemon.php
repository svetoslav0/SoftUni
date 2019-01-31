<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Jan-19
 * Time: 10:33 PM
 */

interface IDemon
{
    public function getMana() : int;
    public function setMana(int $mana) : void;
}