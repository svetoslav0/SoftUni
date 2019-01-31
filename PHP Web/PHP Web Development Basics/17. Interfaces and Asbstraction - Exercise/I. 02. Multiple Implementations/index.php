<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Jan-19
 * Time: 2:44 PM
 */

spl_autoload_register();

$name = readline();
$age = intval(readline());
$id = readline();
$birthDate = readline();

$person = new BCitizen($name, $age, $id, $birthDate);
echo $person;