<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 22-Nov-18
 * Time: 10:54 AM
 */

class Person
{
    /**
     * @var string
     */
    protected $firstName;

    /**
     * @var string
     */
    protected $lastName;

    /**
     * @var DateTime
     */
    protected $birthDate;

    /**
     * Person constructor.
     * @param string $firstName
     * @param string $lastName
     * @param DateTime $birthDate
     */
    public function __construct(string $firstName, string $lastName, DateTime $birthDate)
    {
        $this->setFirstName($firstName);
        $this->setLastName($lastName);
        $this->setBirthDate($birthDate);
    }

    /**
     * @return string
     */
    public function getFirstName(): string
    {
        return $this->firstName;
    }

    /**
     * @param string $firstName
     */
    protected function setFirstName(string $firstName): void
    {
        $this->firstName = $firstName;
    }

    /**
     * @return string
     */
    public function getLastName(): string
    {
        return $this->lastName;
    }

    /**
     * @param string $lastName
     */
    protected function setLastName(string $lastName): void
    {
        $this->lastName = $lastName;
    }

    /**
     * @return DateTime
     */
    public function getBirthDate(): DateTime
    {
        return $this->birthDate;
    }

    /**
     * @param DateTime $birthDate
     */
    protected function setBirthDate(DateTime $birthDate): void
    {
        $this->birthDate = $birthDate;
    }
}