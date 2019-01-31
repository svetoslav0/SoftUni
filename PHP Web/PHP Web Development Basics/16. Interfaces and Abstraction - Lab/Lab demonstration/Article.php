<?php
class Article{
    public $title;
    public $author;
    public $price;

    /**
     * Article constructor.
     * @param $title
     * @param $author
     * @param $price
     */
    public function __construct($title, $author, $price)
    {
        $this->title = $title;
        $this->author = $author;
        $this->price = $price;
    }

    public function printArticle(){
        $html = '<h1>' . $this->title . '</h1>';
        $html .= '<h2>' . $this->author . '</h2>';
        $html .= '<div>' . $this->price . '</div>';
        return $html;
    }


}