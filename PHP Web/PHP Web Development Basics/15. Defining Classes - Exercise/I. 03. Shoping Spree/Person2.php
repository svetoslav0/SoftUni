<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 15-Nov-18
 * Time: 3:48 PM
 */

class Person2
{
    /**
     * @var string
     */
    private $name;

    /**
     * @var float
     */
    private $money;

    /**
     * @var Product[]
     */
    private $bagOfProducts;

    /**
     * Person constructor.
     * @param string $name
     * @param float $money
     * @param Product[] $bagOfProducts
     * @throws Exception
     */
    public function __construct(string $name, float $money, array $bagOfProducts = [])
    {
        $this->setName($name);
        $this->setMoney($money);
        $this->setBagOfProducts($bagOfProducts);
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
    public function getMoney(): float
    {
        return $this->money;
    }

    /**
     * @param float $money
     * @throws Exception
     */
    public function setMoney(float $money): void
    {
        if ($money < 0){
            throw new Exception('Money cannot be negative');
        }
        $this->money = $money;
    }

    /**
     * @return Product[]
     */
    public function getBagOfProducts(): array
    {
        return $this->bagOfProducts;
    }

    /**
     * @param Product[] $bagOfProducts
     */
    public function setBagOfProducts(array $bagOfProducts): void
    {
        $this->bagOfProducts = $bagOfProducts;
    }
}
