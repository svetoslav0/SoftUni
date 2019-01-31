<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 15-Nov-18
 * Time: 3:49 PM
 */

class Product
{
    /**
     * @var string
     */
    private $name;

    /**
     * @var float
     */
    private $cost;

    /**
     * Product constructor.
     * @param string $name
     * @param float $cost
     * @throws Exception
     */
    public function __construct(string $name, float $cost)
    {
        $this->setName($name);
        $this->setCost($cost);
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
     * @throws Exception
     */
    public function setName(string $name): void
    {
        if ($name == ''){
            throw new Exception('Name cannot be empty');
        }
        $this->name = $name;
    }

    /**
     * @return float
     */
    public function getCost(): float
    {
        return $this->cost;
    }

    /**
     * @param float $cost
     * @throws Exception
     */
    public function setCost(float $cost): void
    {
        if ($cost < 0){
            throw new Exception('Money cannot be negative');
        }
        $this->cost = $cost;
    }

}