<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 17-Nov-18
 * Time: 10:13 AM
 */

class Dog extends Animal
{
    /**
     * @return string
     */
    public function __toString()
    {
        return parent::__toString();
    }


    public function produceSound(){
        echo 'BauBau';
    }
}