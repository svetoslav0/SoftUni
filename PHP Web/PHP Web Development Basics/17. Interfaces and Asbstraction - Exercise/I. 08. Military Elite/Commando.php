<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Jan-19
 * Time: 6:21 PM
 */

class Commando extends SpecialisedSoldier implements ICommando
{
    /**
     * @var array
     * codeName => finished
     */
    private $missions = [];

    /**
     * Commando constructor.
     * @param array $data
     * @param array $soldiers
     */
    public function __construct(array $data, array $soldiers)
    {
        parent::__construct($data);
        $this->corps = $data[5];
        $this->addMissions($data);
    }

    /**
     * @return array
     */
    public function getMissions(): array
    {
        return $this->missions;
    }

    /**
     * @param array $data
     */
    public function addMissions(array $data): void
    {
        $data = array_splice($data, 6);
        for($i = 0; $i < count($data) - 1; $i += 2){
            $this->missions[$data[$i]] = $data[$i + 1];
        }
    }

    /**
     * @return string
     */
    public function __toString()
    {
        $result = parent::__toString();
        $result .= 'Corps: ' . $this->getCorps() . PHP_EOL;
        $result .= 'Missions:' . PHP_EOL;
        foreach ($this->getMissions() as $codeName => $state) {
            $result .= '  Code Name: ' . $codeName . ' State: ' . $state . PHP_EOL;
        }
        return $result;
    }
}