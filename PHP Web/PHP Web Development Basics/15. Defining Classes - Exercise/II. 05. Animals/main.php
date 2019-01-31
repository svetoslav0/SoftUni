<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 17-Nov-18
 * Time: 10:07 AM
 */

spl_autoload_register();


while (true){
    $animal = readline();
    if ($animal == 'Beast!'){
        break;
    }
    $line = readline();
    list($name, $age, $gender) = explode(' ', $line);

    if (!class_exists($animal)){
        echo 'Not implemented!' . PHP_EOL;
        break;
    }
    try {
        $a = new $animal($name, $age, $gender);
        echo $a;
        $a->produceSound();
    }catch (Exception $e){
        die($e->getMessage());
    }
}