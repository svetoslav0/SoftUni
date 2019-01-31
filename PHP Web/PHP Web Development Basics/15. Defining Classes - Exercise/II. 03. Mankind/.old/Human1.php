<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 16-Nov-18
 * Time: 9:56 PM
 */

class Human1
{
    /**
     * @var string
     */
    protected $first_name;

    /**
     * @var string
     */
    protected $last_name;

    /**
     * Human constructor.
     * @param string $first_name
     * @param string $last_name
     * @throws Exception
     */
    public function __construct(string $first_name, string $last_name)
    {
        $this->setFirstName($first_name);
        $this->setLastName($last_name);
    }

    /**
     * @return string
     */
    protected function getFirstName(): string
    {
        return $this->first_name;
    }

    /**
     * @param string $first_name
     * @throws Exception
     */
    protected function setFirstName(string $first_name): void
    {
        if (strlen($first_name) < 4){
            throw new Exception('Expected length at least 4 symbols!Argument: firstName');
        }
        if ($first_name[0] == strtolower($first_name[0])){
            throw new Exception('Expected upper case letter!Argument: firstName');
        }
        $this->first_name = $first_name;
    }

    /**
     * @return string
     */
    protected function getLastName(): string
    {
        return $this->last_name;
    }

    /**
     * @param string $last_name
     * @throws Exception
     */
    protected function setLastName(string $last_name): void
    {
        if ($last_name[0] == strtolower($last_name[0])){
            throw new Exception('Expected upper case letter!Argument: lastName');
        }
        if (strlen($last_name) < 3){
            throw new Exception('Expected length at least 3 symbols!Argument: lastName');
        }
        $this->last_name = $last_name;
    }
}