<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 22-Nov-18
 * Time: 11:08 AM
 */

class ChildPerson extends Person
{
    /**
     * @var MainPerson
     */
    protected $parent;

    public function __construct(string $firstName, string $lastName, DateTime $birthDate, MainPerson $parent)
    {
        parent::__construct($firstName, $lastName, $birthDate);
        $this->setParent($parent);
    }

    /**
     * @return MainPerson
     */
    public function getParent(): MainPerson
    {
        return $this->parent;
    }

    /**
     * @param MainPerson $parent
     */
    protected function setParent(MainPerson $parent): void
    {
        $this->parent = $parent;
    }


}