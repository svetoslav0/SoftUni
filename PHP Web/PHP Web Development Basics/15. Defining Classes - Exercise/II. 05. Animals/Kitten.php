<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 17-Nov-18
 * Time: 10:16 AM
 */

class Kitten extends Animal
{
    /**
     * @return string
     * @throws Exception
     */
    public function __toString()
    {
        $this->setGender('Female');
        return parent::__toString();
    }

    public function produceSound(){
        echo 'Miau';
    }
}