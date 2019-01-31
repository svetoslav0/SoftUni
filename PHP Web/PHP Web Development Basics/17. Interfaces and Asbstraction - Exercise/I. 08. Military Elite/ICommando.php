<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Jan-19
 * Time: 6:28 PM
 */

/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 06-Jan-19
 * Time: 6:21 PM
 */
interface ICommando
{
    /**
     * @return array
     */
    public function getMissions(): array;

    /**
     * @param array $data
     */
    public function addMissions(array $data): void;
}