<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Jan-19
 * Time: 5:48 PM
 */

abstract class SpecialisedSoldier extends PrivateSoldier
{
    /**
     * @var string
     */
    protected $corps;

    /**
     * @return string
     */
    public function getCorps(): string
    {
        return $this->corps;
    }

    /**
     * @param string $corps
     */
    public function setCorps(string $corps): void
    {
        $this->corps = $corps;
    }


}