<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 22-Nov-18
 * Time: 10:59 AM
 */

spl_autoload_register();
$person = new MainPerson('Ivan', 'Georgiev', new DateTime('1999-11-11')  , ['Petko'], ['Traqn']);
$parent = new ParentPerson('Todor', 'Georgiev', new DateTime('1969-12-12'), $person);
$person->addParent($parent);

var_dump($person->getParents());






exit;

//--
$firstLine = readline();



$line = readline();

if (!strpos($line, '-')){
    list($firstName, $lastName, $birthDate) = explode(' ', $line);

}else{

}