<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Jan-19
 * Time: 1:34 PM
 */

class Mouse extends Mammal implements ISound, IEat
{

    public function eat(Food $food)
    {
        if (get_class($food) != 'Vegetable'){
            throw new Exception(get_class($this) . 's are not eating that type of food!');
        }
        $this->setFoodEaten($food->getQuantity());
    }

    public function makeSound()
    {
        echo 'SQUEEEAAAK!' . PHP_EOL;
    }
}