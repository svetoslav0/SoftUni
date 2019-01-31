<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Jan-19
 * Time: 6:37 PM
 */

class DApplication
{
    /**
     * @var Soldier[]
     */
    private $soldiers = [];
    public function run(){
        $this->readData();
        $this->printData();
    }

    private function readData()
    {
        while (true){
            $line = readline();
            if ($line === 'End'){
                break;
            }
            $line = explode(' ', $line);
            if ($line[0] == 'Private'){
                $line[0] .= 'Soldier';
            }
            $this->soldiers[] = new $line[0]($line, $this->soldiers);
        }
    }

    private function printData()
    {
        foreach ($this->soldiers as $soldier) {
            echo $soldier;
        }
    }
}