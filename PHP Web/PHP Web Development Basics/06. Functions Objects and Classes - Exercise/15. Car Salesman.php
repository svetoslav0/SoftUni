<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 05-Oct-18
 * Time: 5:42 PM
 */

class Car{
    public $model;
    public $engine;
    public $weight;
    public $color;

    public function __construct($model, $engine, $weight = 'n/a', $color = 'n/a')
    {
        $this->model = $model;
        $this->engine = $engine;
        $this->weight = $weight;
        $this->color = $color;
    }

    /**
     * @return mixed
     */
    public function getModel()
    {
        return $this->model;
    }

    /**
     * @return mixed
     */
    public function getEngine()
    {
        return $this->engine;
    }

    /**
     * @return string
     */
    public function getWeight(): string
    {
        return $this->weight;
    }

    /**
     * @return string
     */
    public function getColor(): string
    {
        return $this->color;
    }

}

class Engine{
    public $model;
    public $power;
    public $displacement;
    public $efficiency;

    /**
     * @return mixed
     */
    public function getModel()
    {
        return $this->model;
    }

    /**
     * @return mixed
     */
    public function getPower()
    {
        return $this->power;
    }

    /**
     * @return string
     */
    public function getDisplacement(): string
    {
        return $this->displacement;
    }

    /**
     * @return string
     */
    public function getEfficiency(): string
    {
        return $this->efficiency;
    }

    public function __construct($model, $power, $displacement = 'n/a', $efficiency = 'n/a')
    {
        $this->model = $model;
        $this->power = $power;
        $this->displacement = $displacement;
        $this->efficiency = $efficiency;
    }


}


$engines = [];
$cars = [];

$n = intval(readline());
while($n-- > 0){
    $line = explode(' ', readline());
    $model = $line[0];
    $power = $line[1];
    if (count($line) == 2){
        $currentEngine = new Engine($model, $power);
    }
    if (count($line) == 3){
        if (is_numeric($line[2])){
            $displacement = $line[2];
            $currentEngine = new Engine($model, $power, $displacement);
        }else{
            $efficiency = $line[2];
            $currentEngine = new Engine($model, $power, 'n/a', $efficiency);
        }
    }elseif (count($line) == 4){
        $displacement = $line[2];
        $efficiency = $line[3];
        $currentEngine = new Engine($model, $power, $displacement, $efficiency);
    }
    $engines[] = $currentEngine;
}

$m = intval(readline());
while ($m-- > 0){
    $line = explode(' ', readline());
    $model = $line[0];
    $engine = $line[1];
    if (count($line) == 2){
        $currentCar = new Car($model, $engine);
    }elseif (count($line) == 3){
        if (is_numeric($line[2])){
            $weight = $line[2];
            $currentCar = new Car($model, $engine, $weight);
        }else{
            $color = $line[2];
            $currentCar = new Car($model, $engine, 'n/a', $color);
        }
    }else{
        $weight = $line[2];
        $color = $line[3];
        $currentCar = new Car($model, $engine, $weight, $color);
    }
    $cars[] = $currentCar;
}


foreach ($cars as $car) {
    echo $car->getModel() . ':' . PHP_EOL;
    echo '  ' . $car->getEngine() . ':' . PHP_EOL;
    $searchedEngine = $car->getEngine();
    $currentEngineDetails = array_filter($engines, function(Engine $eng) use ($searchedEngine){
        return $eng->getModel() == $searchedEngine;
    });
    rsort($currentEngineDetails);
    echo '    Power: ' . $currentEngineDetails[0]->power . PHP_EOL;
    echo '    Displacement: ' . $currentEngineDetails[0]->displacement . PHP_EOL;
    echo '    Efficiency: ' . $currentEngineDetails[0]->efficiency . PHP_EOL;
    echo '  Weight: ' . $car->getWeight() . PHP_EOL;
    echo '  Color: ' . $car->getColor() . PHP_EOL;
}



