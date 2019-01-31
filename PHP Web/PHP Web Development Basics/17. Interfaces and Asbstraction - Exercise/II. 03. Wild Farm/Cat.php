<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Jan-19
 * Time: 2:03 PM
 */

class Cat extends Felime implements IEat, ISound
{
    /**
     * @var string
     */
    private $breed;

    /**
     * Cat constructor.
     * @param array $data
     */
    public function __construct(array $data)
    {
        parent::__construct($data);
        $this->setBreed($data[4]);
    }

    /**
     * @return string
     */
    public function getBreed(): string
    {
        return $this->breed;
    }

    /**
     * @param string $breed
     */
    public function setBreed(string $breed): void
    {
        $this->breed = $breed;
    }

    /**
     * @return string
     */
    public function __toString()
    {
        return sprintf('%s[%s, %s, %s, %s, %s]', get_called_class(), $this->getName(),
            $this->getBreed(), $this->getWeight(), $this->getLivingRegion(), $this->getFoodEaten()) . PHP_EOL;
    }

    public function eat(Food $food)
    {
        $this->setFoodEaten($food->getQuantity());
    }

    public function makeSound()
    {
        echo 'Meowwww' . PHP_EOL;
    }
}