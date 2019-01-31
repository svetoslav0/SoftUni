<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 28-Dec-18
 * Time: 8:32 PM
 */

spl_autoload_register();

$article = new Article('Yohoho', 'Mark', 20.5);
echo $article->printArticle();