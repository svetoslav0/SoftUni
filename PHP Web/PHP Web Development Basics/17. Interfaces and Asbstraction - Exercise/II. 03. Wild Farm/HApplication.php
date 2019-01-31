<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Jan-19
 * Time: 12:58 PM
 */

class HApplication
{
    public function run(){
        while (true){
            $line = readline();
            if ($line === 'End'){
                break;
            }
            $animalData = explode(' ', $line);
            $foodData = explode(' ', readline());
            $currentAnimal = new $animalData[0]($animalData);
            $currentFood = new $foodData[0]($foodData);
            $currentAnimal->makeSound();
            try{
                $currentAnimal->eat($currentFood);
            }catch (Exception $e){
                echo $e->getMessage() . PHP_EOL;
            }
            echo $currentAnimal;
        }
    }
}