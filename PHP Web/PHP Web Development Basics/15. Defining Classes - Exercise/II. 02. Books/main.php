<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 16-Nov-18
 * Time: 8:23 PM
 */

spl_autoload_register();

$author = readline();
$title = readline();
$price = doubleval(readline());
$book_type = readline();

switch ($book_type){
    case 'STANDARD':
        try{
            $b = new Book($title, $author, $price);
            echo $b;
        }catch (Exception $exception){
            echo $exception->getMessage();
        }
        break;
    case 'GOLD':
        try{
            $b = new GoldenEditionBook($title, $author, $price);
            echo $b;
        }catch (Exception $exception){
            echo $exception->getMessage();
        }
        break;
    default:
        die('Type is not valid!');
        break;
}
