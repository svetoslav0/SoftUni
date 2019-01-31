<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Jan-19
 * Time: 10:30 PM
 */

class Demon extends Characters implements IDemon
{
    /**
     * @var int
     */
    private $mana;

    /**
     * Demon constructor.
     * @param string $username
     * @param int $level
     * @param int $mana
     */
    public function __construct(string $username, int $level, int $mana)
    {
        parent::__construct($username, $level);
        $this->setMana($mana);
        $this->generatePassword();
    }

    /**
     * @return int
     */
    public function getMana(): int
    {
        return $this->mana;
    }

    /**
     * @param int $mana
     */
    public function setMana(int $mana): void
    {
        $this->mana = $mana;
    }

    protected function generatePassword() : void
    {
        $this->password = strlen($this->getUsername()) * 217;
    }

    /**
     * @return string
     */
    public function __toString()
    {
        $result = '"' . $this->getUsername() . '" | "' . $this->getPassword() . '" -> ' . get_class() . PHP_EOL;
        $result .= number_format($this->getLevel() * $this->getMana(), 1, '.', '');
        return $result;
    }
}