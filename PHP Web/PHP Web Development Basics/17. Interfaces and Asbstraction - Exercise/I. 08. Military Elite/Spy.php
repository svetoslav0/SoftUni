<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Jan-19
 * Time: 5:17 PM
 */

class Spy extends Soldier implements ISpy
{
    /**
     * @var string
     */
    private $codeNumber;

    /**
     * Spy constructor.
     * @param array $data
     */
    public function __construct(array $data)
    {
        $this->id = $data[1];
        $this->firstName = $data[2];
        $this->lastName = $data[3];
        $this->setCodeNumber(intval($data[4]));
    }

    /**
     * @return string
     */
    public function getCodeNumber(): string
    {
        return $this->codeNumber;
    }

    /**
     * @param int $codeNumber
     */
    public function setCodeNumber(int $codeNumber): void
    {
        $this->codeNumber = $codeNumber;
    }

    /**
     * @return string
     */
    public function __toString()
    {
        $result = 'Name: ' . $this->getFirstName() . ' ' . $this->getLastName();
        $result .= ' Id: ' . $this->getId() . PHP_EOL;
        $result .= 'Code Number: ' . $this->getCodeNumber() . PHP_EOL;
        return $result;
    }
}