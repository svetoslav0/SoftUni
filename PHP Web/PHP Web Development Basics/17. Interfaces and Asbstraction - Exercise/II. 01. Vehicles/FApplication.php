<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Dec-18
 * Time: 11:53 AM
 */

class FApplication
{
    private $vehicles = [];

    public function run(){
        $this->readData();
        $this->printMediumData();
        $this->printFinalData();
    }

    public function readData()
    {
        $line1 = readline();
        $line2 = readline();

        [$type1, $fuel1, $consumption1] = explode(' ', $line1);
        [$type2, $fuel2, $consumption2] = explode(' ', $line2);

        $this->vehicles[$type1] = new $type1($fuel1, $consumption1);
        $this->vehicles[$type2] = new $type2($fuel2, $consumption2);
    }

    public function printMediumData(){
        $n = intval(readline());
        while ($n-- > 0){
            $line = readline();
            [$operation, $type, $data] = explode(' ', $line);

            $this->vehicles[$type]->$operation($data);
            echo $this->vehicles[$type]->getLastStatus();
        }
    }

    public function printFinalData(){
        /**
         * @var Vehicle $vehicle
         */
        foreach ($this->vehicles as $vehicle_class => $vehicle) {
            echo $vehicle_class . ': ' . number_format($vehicle->getFuel(), 2, '.', '') . PHP_EOL;
        }
    }
}