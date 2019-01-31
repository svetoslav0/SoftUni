<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 05-Jan-19
 * Time: 5:16 PM
 */

class Pet implements IName, IBirthDay
{
    /**
     * @var string
     */
    private $name;

    /**
     * @var string
     */
    private $birthDate;

    /**
     * Pet constructor.
     * @param array $data
     */
    public function __construct(array $data)
    {
        $this->setName($data[1]);
        $this->setBirthDate($data[2]);
    }

    /**
     * @param string $birthDate
     */
    public function setBirthDate(string $birthDate): void
    {
        $this->birthDate = $birthDate;
    }

    /**
     * @param string $name
     */
    public function setName(string $name): void
    {
        $this->name = $name;
    }

    /**
     * @return string
     */
    public function getBirthDate(): string
    {
        return $this->birthDate;
    }
}