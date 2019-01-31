<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Jan-19
 * Time: 1:20 PM
 */

abstract class Food
{
    /**
     * @var int
     */
    protected $quantity;

    /**
     * Food constructor.
     * @param array $data
     */
    public function __construct(array $data)
    {
        $this->setQuantity($data[1]);
    }

    /**
     * @return int
     */
    public function getQuantity(): int
    {
        return $this->quantity;
    }

    /**
     * @param int $quantity
     */
    public function setQuantity(int $quantity): void
    {
        $this->quantity = $quantity;
    }
}