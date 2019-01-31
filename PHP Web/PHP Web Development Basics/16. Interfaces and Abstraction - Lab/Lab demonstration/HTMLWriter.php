<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 28-Dec-18
 * Time: 8:40 PM
 */

class HTMLWriter
{
    public function write(Article $article){
        $html = '<h1>' . $article->title . '</h1>';
        $html .= '<h2>' . $article->author . '</h2>';
        $html .= '<div>' . $article->price . '</div>';
        return $html;
    }
}