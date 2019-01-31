<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Jan-19
 * Time: 5:19 PM
 */

class LeutenantGeneral extends PrivateSoldier implements ILeutenantGeneral
{
    /**
     * @var array
     */
    private $privates = [];

    /**
     * @var array
     */
    private $soldiers = [];

    /**
     * LeutenantGeneral constructor.
     * @param array $data
     * @param array $soldiers
     */
    public function __construct(array $data, array $soldiers)
    {
        parent::__construct($data);
        $this->addPrivates($data);
        $this->setSoldiers($soldiers);
    }

    /**
     * @param array $data
     */
    public function addPrivates(array $data){
        $data = array_splice($data, 5);
        $this->privates = array_merge($this->privates, $data);
    }

    /**
     * @return array
     */
    public function getPrivates(){
        return $this->privates;
    }

    /**
     * @return string
     */
    public function __toString()
    {
        $result = parent::__toString();
        $result .= 'Privates:' . PHP_EOL;
        foreach ($this->privates as $privateId) {
            foreach ($this->getAllSoldiers() as $currentSoldier) {
                if ($privateId == $currentSoldier->getId()){
                    $result .= '  Name: ' . $currentSoldier->getFirstName() . ' ' . $currentSoldier->getLastName();
                    $result .= ' Id: ' . $privateId . ' Salary: ' . $currentSoldier->getSalary() . PHP_EOL;
                }
            }
        }
        return $result;
    }

    /**
     * @return array
     */
    private function getAllSoldiers()
    {
        return $this->soldiers;
    }

    /**
     * @param array $soldiers
     */
    private function setSoldiers(array $soldiers)
    {
        $this->soldiers = $soldiers;
    }
}