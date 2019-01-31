<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Jan-19
 * Time: 2:22 PM
 */

interface Person
{
    public function setName(string $name) : void;
    public function setAge(int $age) : void;
}