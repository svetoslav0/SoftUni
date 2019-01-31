<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 05-Jan-19
 * Time: 5:23 PM
 */

class BApplication
{
    /**
     * @var array
     */
    private $inhabitants = [];

    /**
     * @var int
     */
    private $specialYear;

    public function run(){
        $this->readData();
        $this->printData();
    }

    private function readData()
    {
        $line = readline();

        while (true){
            if ($line == 'End'){
                break;
            }
            $data = explode(' ', $line);
            $this->inhabitants[] = new $data[0]($data);
            $line = readline();
        }
        $this->specialYear = readline();
    }

    private function printData()
    {
        foreach ($this->inhabitants as $inhabitant) {
            if (is_callable(array(get_class($inhabitant), 'getBirthDate'))){
                $birthDate = $inhabitant->getBirthDate();
                $birthData = explode('/', $birthDate);
                $birthYear = $birthData[2];
                if ($birthYear == $this->specialYear){
                    echo $birthDate . PHP_EOL;
                }
            }
        }
    }
}