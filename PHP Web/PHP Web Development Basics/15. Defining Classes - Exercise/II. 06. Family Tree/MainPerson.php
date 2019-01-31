<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 22-Nov-18
 * Time: 11:05 AM
 */

class MainPerson extends Person
{
    /**
     * @var ChildPerson[]
     */
    protected $children;

    /**
     * @var ParentPerson[]
     */
    protected $parents;

    public function __construct(string $firstName, string $lastName, DateTime $birthDate, array $children, array $parents)
    {
        parent::__construct($firstName, $lastName, $birthDate);
        $this->setChildren($children);
        $this->setParents($parents);
    }

    /**
     * @return ChildPerson[]
     */
    public function getChildren(): array
    {
        return $this->children;
    }

    /**
     * @param ChildPerson[] $children
     */
    protected function setChildren(array $children): void
    {
        $this->children = $children;
    }

    /**
     * @return ParentPerson[]
     */
    public function getParents(): array
    {
        return $this->parents;
    }

    /**
     * @param ParentPerson[] $parents
     */
    protected function setParents(array $parents): void
    {
        $this->parents = $parents;
    }

    public function addParent(ParentPerson $parent){
        $this->parents[] = $parent;
    }

    public function addChild(ChildPerson $child){
        $this->children[] = $child;
    }


}