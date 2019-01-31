<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Jan-19
 * Time: 3:08 PM
 */


interface BCar
{
    public function setDriverName(string $name) : void;
}


class BFerrari implements BCar
{

    const MODEL = '488-Spider';
    const BRAKES = 'Brakes!';
    const GAS_PEDAL = 'Zadu6avam sA!';

    /**
     * @var string
     */
    private $driverName;

    /**
     * Ferrari constructor.
     * @param string $driverName
     */
    public function __construct(string $driverName)
    {
        $this->driverName = $driverName;
    }

    /**
     * @param string $name
     */
    public function setDriverName(string $name): void
    {
        $this->driverName = $name;
    }

    public function __toString()
    {
        return self::MODEL . '/' . self::BRAKES . '/' . self::GAS_PEDAL . '/' . $this->driverName;
    }
}

$driverName = readline();

$ferrari = new BFerrari($driverName);
echo $ferrari;