<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Jan-19
 * Time: 2:10 PM
 */

class Tiger extends Felime implements IEat, ISound
{
    public function eat(Food $food)
    {
        if (get_class($food) != 'Meat'){
            throw new Exception(get_class($this) . 's are not eating that type of food!');
        }
        $this->setFoodEaten($food->getQuantity());
    }

    public function makeSound()
    {
        echo 'ROAAR!!!' . PHP_EOL;
    }
}