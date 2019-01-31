<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 28-Dec-18
 * Time: 8:54 PM
 */

interface WriterInterface
{
    public function write(Article $article);
}