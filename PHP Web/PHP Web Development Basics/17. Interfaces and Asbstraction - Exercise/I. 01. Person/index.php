<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Jan-19
 * Time: 2:35 PM
 */

spl_autoload_register();

$name = readline();
$age = intval(readline());

$person = new DCitizen($name, $age);
echo $person;