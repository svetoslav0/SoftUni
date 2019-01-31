<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Jan-19
 * Time: 1:18 PM
 */

abstract class Animal
{
    /**
     * @var string
     */
    protected $name;

    /**
     * @var float
     */
    protected $weight;

    /**
     * @var int
     */
    protected $foodEaten = 0;

    /**
     * Animal constructor.
     * @param array $data
     */
    public function __construct(array $data)
    {
        $this->setName($data[1]);
        $this->setWeight($data[2]);
    }

    /**
     * @return string
     */
    public function getName(): string
    {
        return $this->name;
    }

    /**
     * @param string $name
     */
    public function setName(string $name): void
    {
        $this->name = $name;
    }

    /**
     * @return float
     */
    public function getWeight(): float
    {
        return $this->weight;
    }

    /**
     * @param float $weight
     */
    public function setWeight(float $weight): void
    {
        $this->weight = $weight;
    }

    /**
     * @return int
     */
    public function getFoodEaten(): int
    {
        return $this->foodEaten;
    }

    /**
     * @param int $foodEaten
     */
    public function setFoodEaten(int $foodEaten): void
    {
        $this->foodEaten = $foodEaten;
    }
}