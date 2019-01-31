<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Dec-18
 * Time: 9:21 AM
 */

class App
{
    private $results = [];

    public function run(){
       $this->readData();
       $this->printAllData();
    }

    private function readData(){
        $line = readline();

        while(!$line == ''){
            [$type, $firstName, $lastName, $email] = explode(' ', $line);

            if (!class_exists($type)){
                throw new Exception('Person type not found...', 498);
            }

            $this->results[] = new $type($firstName, $lastName, $email);
            $line = readline();
        }
    }

    private function printAllData(){
        foreach ($this->results as $result) {
            echo $result->printData();
        }
    }
}