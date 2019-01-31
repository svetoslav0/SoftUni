<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Jan-19
 * Time: 10:35 AM
 */

interface IBirthable
{
    public function setID(string $id) : void;
    public function setBirthDate(string $birthDate) : void;
}