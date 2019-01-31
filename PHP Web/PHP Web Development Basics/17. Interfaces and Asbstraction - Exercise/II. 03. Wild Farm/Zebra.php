<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Jan-19
 * Time: 2:14 PM
 */

class Zebra extends Mammal implements IEat, ISound
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
        echo 'Zs' . PHP_EOL;
    }
}