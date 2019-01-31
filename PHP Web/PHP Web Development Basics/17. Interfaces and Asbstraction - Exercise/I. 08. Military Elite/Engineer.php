<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Jan-19
 * Time: 6:02 PM
 */

class Engineer extends SpecialisedSoldier implements IEngineer
{
    /**
     * @var array
     * partName => hoursWorked
     */
    private $repairs = [];

    /**
     * Engineer constructor.
     * @param array $data
     * @param array $soldiers
     */
    public function __construct(array $data, array $soldiers)
    {
        parent::__construct($data);
        $this->corps = $data[5];
        $this->addRepair($data);
    }

    /**
     * @param array $data
     */
    public function addRepair(array $data){
        $data = array_splice($data, 6);
        for($i = 0; $i < count($data) - 1; $i += 2){
            $this->repairs[$data[$i]] = $data[$i + 1];
        }
    }

    /**
     * @return array
     */
    public function getRepairs(){
        return $this->repairs;
    }

    /**
     * @return string
     */
    public function __toString()
    {
        $result = parent::__toString();
        $result .= 'Corps: ' . $this->getCorps() . PHP_EOL;
        $result .= 'Repairs:' . PHP_EOL;
        foreach ($this->repairs as $partName => $hoursWorked) {
            $result .= '  Part Name: ' . $partName . ' Hours Worked: ' . $hoursWorked . PHP_EOL;
        }
        return $result;
    }
}