<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 16-Nov-18
 * Time: 8:20 PM
 */

class GoldenEditionBook extends Book
{
    protected function getPrice(): float
    {
        return parent::getPrice() * 1.3;
    }
}