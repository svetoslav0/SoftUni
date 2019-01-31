<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 10-Dec-18
 * Time: 8:54 AM
 */

spl_autoload_register();

try{
    $app = new App();
    $app->run();
}catch (Exception $e){
    echo 'Some error: ' . $e->getMessage() . "\n";
    echo 'Error code: ' . $e->getCode();
}

