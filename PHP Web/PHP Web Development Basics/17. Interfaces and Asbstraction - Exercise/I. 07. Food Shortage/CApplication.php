<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Jan-19
 * Time: 10:29 AM
 */

class CApplication
{
    /**
     * @var array
     */
    private $citizens = [];

    /**
     * @var int
     */
    private $foodUnits = 0;

    public function run()
    {
        $this->readDate();
        $this->buyFood();
        $this->printOutput();
    }

    private function readDate()
    {
        $n = intval(readline());
        while ($n-- > 0){
            $line = explode(' ', readline());
            if (count($line) == 3){
                $this->citizens[$line[0]] = new Rebel($line[0], $line[1], $line[2]);
            }elseif(count($line) == 4){
                $this->citizens[$line[0]] = new HCitizen($line[0], $line[1], $line[2], $line[3]);
            }
        }
    }

    private function buyFood()
    {
        $name = readline();
        while (true){
            if ($name === 'End'){
                break;
            }
            if (array_key_exists($name, $this->citizens)){
                if (get_class($this->citizens[$name]) == 'Rebel'){
                    $this->foodUnits += 5;
                }else{
                    $this->foodUnits += 10;
                }
            }
            $name = readline();
        }
    }

    private function printOutput()
    {
        echo $this->foodUnits;
    }
}