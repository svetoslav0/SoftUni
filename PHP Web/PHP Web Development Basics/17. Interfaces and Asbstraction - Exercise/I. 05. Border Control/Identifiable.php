<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 05-Jan-19
 * Time: 4:21 PM
 */

abstract class Identifiable
{
    /**
     * @var string
     */
    private $id;

    /**
     * @return string
     */
    public function getId(): string
    {
        return $this->id;
    }

    /**
     * @param string $id
     */
    public function setId(string $id): void
    {
        $this->id = $id;
    }

    public function checkId(string $controlNumber, string $id){
        if ($controlNumber == substr($id, -strlen($controlNumber))){
            return true;
        }
        return false;
    }
}