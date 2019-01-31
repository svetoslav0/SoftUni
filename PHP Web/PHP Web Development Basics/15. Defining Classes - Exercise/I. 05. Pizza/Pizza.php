<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 16-Nov-18
 * Time: 6:46 PM
 */

class Pizza
{
    /**
     * @var string
     */
    private $name;

    /**
     * @var Dough
     */
    private $dough;

    /**
     * @var Topping[]
     */
    private $toppings;

    /**
     * @var int
     */
    private $toppings_number;

    /**
     * Pizza constructor.
     * @param string $name
     * @param Dough $dough
     * @param Topping[] $toppings
     * @param int $toppings_number
     * @throws Exception
     */
    public function __construct(string $name, Dough $dough, array $toppings, int $toppings_number)
    {
        $this->setName($name);
        $this->setDough($dough);
        $this->setToppings($toppings);
        $this->setToppingsNumber($toppings_number);
    }

    /**
     * @return string
     */
    private function getName(): string
    {
        return $this->name;
    }

    /**
     * @param string $name
     * @throws Exception
     */
    private function setName(string $name): void
    {
        if (strlen($name) < 1 || strlen($name) > 15){
            throw new Exception('Pizza name should be between 1 and 15 symbols.');
        }
        $this->name = $name;
    }

    /**
     * @return Dough
     */
    private function getDough(): Dough
    {
        return $this->dough;
    }

    /**
     * @param Dough $dough
     */
    private function setDough(Dough $dough): void
    {
        $this->dough = $dough;
    }

    /**
     * @return Topping[]
     */
    private function getToppings(): array
    {
        return $this->toppings;
    }

    /**
     * @param Topping[] $toppings
     */
    private function setToppings(array $toppings): void
    {
        $this->toppings = $toppings;
    }

    /**
     * @return int
     */
    private function getToppingsNumber(): int
    {
        return $this->toppings_number;
    }

    /**
     * @param int $toppings_number
     * @throws Exception
     */
    private function setToppingsNumber(int $toppings_number): void
    {
        if ($toppings_number < 0 || $toppings_number > 10){
            throw new Exception('Number of toppings should be in range [0..10].');
        }
        $this->toppings_number = $toppings_number;
    }



    private function calculateFinalCalories(){
        $dough_calories = $this->getDough()->getCalories();
        $topping_calories = 0;
        foreach ($this->getToppings() as $topping) {
            $current_calories = $topping->getCalories();
            $topping_calories += $current_calories;
        }
        $final_calories = $dough_calories + $topping_calories;
        return number_format($final_calories, 2, '.', '');
    }

    public function __toString()
    {
        return $this->getName() . ' - ' . $this->calculateFinalCalories() . ' Calories.';
    }
}