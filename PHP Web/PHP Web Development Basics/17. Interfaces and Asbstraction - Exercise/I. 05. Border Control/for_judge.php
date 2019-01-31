<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 05-Jan-19
 * Time: 4:45 PM
 */


abstract class JIdentifiable
{
    /**
     * @var string
     */
    private $id;

    /**
     * @return string
     */
    public function getId(): string
    {
        return $this->id;
    }

    /**
     * @param string $id
     */
    public function setId(string $id): void
    {
        $this->id = $id;
    }

    public function checkId(string $controlNumber, string $id){
        if ($controlNumber == substr($id, -strlen($controlNumber))){
            return true;
        }
        return false;
    }
}


class JCitizen extends JIdentifiable
{
    /**
     * @var string
     */
    private $name;

    /**
     * @var int
     */
    private $age;

    /**
     * BCitizen constructor.
     * @param string $name
     * @param int $age
     * @param string $id
     */
    public function __construct(string $name, int $age, string $id)
    {
        $this->setName($name);
        $this->setAge($age);
        $this->setId($id);
    }

    /**
     * @return string
     */
    public function getName(): string
    {
        return $this->name;
    }

    /**
     * @param string $name
     */
    public function setName(string $name): void
    {
        $this->name = $name;
    }

    /**
     * @return int
     */
    public function getAge(): int
    {
        return $this->age;
    }

    /**
     * @param int $age
     */
    public function setAge(int $age): void
    {
        $this->age = $age;
    }
}


class JRobot extends JIdentifiable
{
    /**
     * @var string
     */
    private $model;

    /**
     * Robot constructor.
     * @param string $model
     * @param string $id
     */
    public function __construct(string $model, string $id)
    {
        $this->setModel($model);
        $this->setId($id);
    }

    /**
     * @return string
     */
    public function getModel(): string
    {
        return $this->model;
    }

    /**
     * @param string $model
     */
    public function setModel(string $model): void
    {
        $this->model = $model;
    }
}


class JApplication
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
                $this->inhabitants[$data[1]] = new JRobot($data[0], $data[1]);
            }elseif(count($data) == 3){
                $this->inhabitants[$data[2]] = new JCitizen($data[0], $data[1], $data[2]);
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

$app = new JApplication();
$app->run();