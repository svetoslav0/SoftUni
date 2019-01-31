<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Jan-19
 * Time: 3:09 PM
 */

spl_autoload_register();

$numbers = readline();
$sites = readline();

$phone = new Smartphone();
$phone->call($numbers);
$phone->browse($sites);
