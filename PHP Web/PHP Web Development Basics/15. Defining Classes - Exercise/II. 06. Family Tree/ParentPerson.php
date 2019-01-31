<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 22-Nov-18
 * Time: 11:07 AM
 */

class ParentPerson extends Person
{
    /**
     * @var MainPerson
     */
    protected $child;

    public function __construct(string $firstName, string $lastName, DateTime $birthDate, MainPerson $child)
    {
        parent::__construct($firstName, $lastName, $birthDate);
        $this->setChild($child);
    }

    /**
     * @return MainPerson
     */
    public function getChild(): MainPerson
    {
        return $this->child;
    }

    /**
     * @param MainPerson $child
     */
    protected function setChild(MainPerson $child): void
    {
        $this->child = $child;
    }


}