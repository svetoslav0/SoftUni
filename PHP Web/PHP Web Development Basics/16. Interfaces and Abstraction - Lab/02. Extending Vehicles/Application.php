<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 30-Dec-18
 * Time: 11:53 AM
 */

class Application
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
        $line3 = readline();

        [$type1, $fuel1, $consumption1, $capacity1] = explode(' ', $line1);
        [$type2, $fuel2, $consumption2, $capacity2] = explode(' ', $line2);
        [$type3, $fuel3, $consumption3, $capacity3] = explode(' ', $line3);

        $this->vehicles[$type1] = new $type1($fuel1, $consumption1, $capacity1);
        $this->vehicles[$type2] = new $type2($fuel2, $consumption2, $capacity2);
        $this->vehicles[$type3] = new $type3($fuel3, $consumption3, $capacity3);
    }

    public function printMediumData(){
        $n = intval(readline());
        while ($n-- > 0){
            $line = readline();
            try{
                [$operation, $type, $data] = explode(' ', $line);
                $this->vehicles[$type]->$operation($data);
                echo $this->vehicles[$type]->getLastStatus();
            }catch (Exception $e){
                echo $e->getMessage();
            }

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