<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 16-Nov-18
 * Time: 12:18 PM
 */

class Topping
{
    const MEAT_MODIFIER = 1.2;
    const VEGGIES_MODIFIER = 0.8;
    const CHEESE_MODIFIER = 1.1;
    const SAUCE_MODIFIER = 0.9;

    /**
     * @var string
     * 'meat', 'veggies', 'cheese' or 'sauce'
     */
    private $type;

    /**
     * @var float
     */
    private $weight;

    /**
     * Topping constructor.
     * @param string $type
     * @param float $weight
     * @throws Exception
     */
    public function __construct(string $type, float $weight)
    {
        $this->setType($type);
        $this->setWeight($weight);
    }


    /**
     * @return string
     */
    private function getType(): string
    {
        return $this->type;
    }

    /**
     * @param string $type
     * @throws Exception
     */
    private function setType(string $type): void
    {
        $types = ['meat', 'veggies', 'cheese', 'sauce'];
        if (!in_array(strtolower($type), $types)){
            throw new Exception("Cannot place {$type} on top of your pizza.");
        }
        $this->type = $type;
    }

    /**
     * @return float
     */
    private function getWeight(): float
    {
        return $this->weight;
    }

    /**
     * @param float $weight
     * @throws Exception
     */
    private function setWeight(float $weight): void
    {
        if ($weight < 1 || $weight > 50){
            throw new Exception("{$this->type} weight should be in the range [1..50].");
        }
        $this->weight = $weight;
    }

    public function getCalories() : float{
        $type_modifier = '';
        switch (strtolower($this->getType())){
            case 'meat':
                $type_modifier = self::MEAT_MODIFIER;
                break;
            case 'veggies':
                $type_modifier = self::VEGGIES_MODIFIER;
                break;
            case 'cheese':
                $type_modifier = self::CHEESE_MODIFIER;
                break;
            case 'sauce':
                $type_modifier = self::SAUCE_MODIFIER;
                break;
        }

        $calories = 2 * $type_modifier * $this->getWeight();
        return number_format($calories, 2, '.', '');
    }

}