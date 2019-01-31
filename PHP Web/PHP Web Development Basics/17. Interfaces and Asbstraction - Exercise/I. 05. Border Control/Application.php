<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 05-Jan-19
 * Time: 3:32 PM
 */

class Application
{
    /**
     * @var array
     */
    private $inhabitants = [];

    /**
     * @var string
     */
    private $controlNumber;

    public function run(){
        $this->readData();
        $this->printFakeIDs();
    }
    private function readData(){
        $line = readline();
        while (true){
            if ($line === 'End'){
                break;
            }
            $data = explode(' ', $line);
            if (count($data) == 2){
                $this->inhabitants[$data[1]] = new CRobot($data[0], $data[1]);
            }elseif(count($data) == 3){
                $this->inhabitants[$data[2]] = new CCitizen($data[0], $data[1], $data[2]);
            }
            $line = readline();
        }
        $this->controlNumber = readline();
    }

    private function printFakeIDs()
    {
        foreach ($this->inhabitants as $inhabitant) {
            if ($inhabitant->checkId($this->controlNumber, $inhabitant->getId())){
                echo $inhabitant->getId() . PHP_EOL;
            }
        }
    }
}