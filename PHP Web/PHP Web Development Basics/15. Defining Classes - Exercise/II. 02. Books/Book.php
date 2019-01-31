<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 16-Nov-18
 * Time: 8:17 PM
 */

class Book
{
    /**
     * @var string
     */
    protected $title;

    /**
     * @var string
     */
    protected $author;

    /**
     * @var float
     */
    protected $price;

    /**
     * Book constructor.
     * @param string $title
     * @param string $author
     * @param float $price
     * @throws Exception
     */
    public function __construct(string $title, string $author, float $price)
    {
        $this->setTitle($title);
        $this->setAuthor($author);
        $this->setPrice($price);
    }


    /**
     * @return string
     */
    protected function getTitle(): string
    {
        return $this->title;
    }

    /**
     * @param string $title
     * @throws Exception
     */
    protected function setTitle(string $title): void
    {
        if (strlen($title) < 3){
            throw new Exception("Title not valid!");
        }
        $this->title = $title;
    }

    /**
     * @return string
     */
    protected function getAuthor(): string
    {
        return $this->author;
    }

    /**
     * @param string $author
     * @throws Exception
     */
    protected function setAuthor(string $author): void
    {
        $names = explode(' ', $author);
        $second_name = $names[1];
        if (is_numeric($second_name[0])){
            throw new Exception('Author not valid!');
        }
        $this->author = $author;
    }

    /**
     * @return float
     */
    protected function getPrice(): float
    {
        return $this->price;
    }

    /**
     * @param float $price
     * @throws Exception
     */
    protected function setPrice(float $price): void
    {
        if ($price <= 0){
            throw new Exception("Price not valid!");
        }
        $this->price = $price;
    }

    public function __toString()
    {
        $result = 'OK' . PHP_EOL;
        $result .= $this->getPrice();
        return $result;
    }

}