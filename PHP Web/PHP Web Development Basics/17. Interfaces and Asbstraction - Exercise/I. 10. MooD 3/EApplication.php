<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Jan-19
 * Time: 10:13 PM
 */

class EApplication
{
    public function run(){
        $line = explode(' | ', readline());
        $character = new $line[1]($line[0], $line[2], $line[3]);
        echo $character;
    }
}