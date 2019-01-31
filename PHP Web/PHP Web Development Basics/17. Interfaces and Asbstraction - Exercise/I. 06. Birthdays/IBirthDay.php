<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 05-Jan-19
 * Time: 5:14 PM
 */

interface IBirthDay
{
    public function setBirthDate(string $birthDate) : void;
    public function getBirthDate() : string;
}