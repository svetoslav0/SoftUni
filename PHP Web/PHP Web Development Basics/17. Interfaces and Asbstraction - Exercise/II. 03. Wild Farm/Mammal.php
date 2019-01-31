<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Jan-19
 * Time: 1:24 PM
 */

class Mammal extends Animal
{
    /**
     * @var string
     */
    protected $livingRegion;

    /**
     * Mammal constructor.
     * @param array $data
     */
    public function __construct(array $data)
    {
        parent::__construct($data);
        $this->setLivingRegion($data[3]);
    }

    /**
     * @return string
     */
    public function getLivingRegion(): string
    {
        return $this->livingRegion;
    }

    /**
     * @param string $livingRegion
     */
    public function setLivingRegion(string $livingRegion): void
    {
        $this->livingRegion = $livingRegion;
    }

    /**
     * @return string
     */
    public function __toString()
    {
        return sprintf('%s[%s, %s, %s, %s]', get_called_class(), $this->getName(),
            $this->getWeight(), $this->getLivingRegion(), $this->getFoodEaten()) . PHP_EOL;
    }
}