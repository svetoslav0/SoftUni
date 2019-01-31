<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 17-Nov-18
 * Time: 10:17 AM
 */

class Tomcat extends Animal
{
    /**
     * @return string
     * @throws Exception
     */
    public function __toString()
    {
        $this->setGender('Male');
        return parent::__toString();
    }

    public function produceSound(){
        echo 'Give me one million b***h';
    }
}