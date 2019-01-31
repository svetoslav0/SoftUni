<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 02-Jan-19
 * Time: 2:57 PM
 */

spl_autoload_register();

$driverName = readline();

$ferrari = new Ferrari($driverName);
echo $ferrari;