<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Jan-19
 * Time: 10:31 PM
 */

class Archangel extends Characters implements IArchangel
{
    /**
     * @var float
     */
    private $energy;

    /**
     * Archangel constructor.
     * @param string $username
     * @param int $level
     * @param float $energy
     */
    public function __construct(string $username, int $level, float $energy)
    {
        parent::__construct($username, $level);
        $this->setEnergy($energy);
        $this->generatePassword();
    }

    /**
     * @return float
     */
    public function getEnergy(): float
    {
        return $this->energy;
    }

    /**
     * @param float $energy
     */
    public function setEnergy(float $energy): void
    {
        $this->energy = $energy;
    }

    protected function generatePassword() : void
    {
        $this->password = strrev($this->getUsername()) . strlen($this->getUsername()) * 21;
    }

    /**
     * @return string
     */
    public function __toString()
    {
        $result = '"' . $this->getUsername() . '" | "' . $this->getPassword() . '" -> ' . get_class() . PHP_EOL;
        $result .= $this->getLevel() * $this->getEnergy();
        return $result;
    }
}