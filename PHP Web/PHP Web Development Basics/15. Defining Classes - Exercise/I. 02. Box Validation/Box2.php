<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 15-Nov-18
 * Time: 3:41 PM
 */

class Box2
{

    /**
     * @var float
     */
    private $length;

    /**
     * @var float
     */
    private $width;

    /**
     * @var float
     */
    private $height;

    /**
     * Box constructor.
     * @param float $length
     * @param float $width
     * @param float $height
     * @throws Exception
     */
    public function __construct(float $length, float $width, float $height)
    {
        $this->setLength($length);
        $this->setWidth($width);
        $this->setHeight($height);
    }

    /**
     * @return float
     */
    private function getLength(): float
    {
        return $this->length;
    }

    /**
     * @param float $length
     * @throws Exception
     */
    private function setLength(float $length): void
    {
        if ($length <= 0){
            throw new Exception("Length cannot be zero or negative.");
        }
        $this->length = $length;
    }

    /**
     * @return float
     */
    private function getWidth(): float
    {
        return $this->width;
    }

    /**
     * @param float $width
     * @throws Exception
     */
    private function setWidth(float $width): void
    {
        if ($width <= 0){
            throw new Exception("Width cannot be zero or negative.");
        }
        $this->width = $width;
    }

    /**
     * @return float
     */
    private function getHeight(): float
    {
        return $this->height;
    }

    /**
     * @param float $height
     * @throws Exception
     */
    private function setHeight(float $height): void
    {
        if ($height <= 0){
            throw new Exception("Height cannot be zero or negative.");
        }
        $this->height = $height;
    }

    private function getSurfaceArea(){
        $length = $this->getLength();
        $width = $this->getWidth();
        $height = $this->getHeight();

        $result = 2 * $length * $width + 2 * $length * $height + 2 * $width * $height;
        return number_format($result, 2, '.', '');
    }

    private function getLateralSurfaceArea(){
        $length = $this->getLength();
        $width = $this->getWidth();
        $height = $this->getHeight();

        $result = 2 * $length * $height + 2 * $width * $height;
        return number_format($result, 2, '.', '');
    }

    private function getVolume(){
        $result = $this->getLength() * $this->getWidth() * $this->getHeight();
        return number_format($result, 2, '.', '');
    }

    public function __toString()
    {
        $result = 'Surface Area - ' . $this->getSurfaceArea() . PHP_EOL;
        $result .= 'Lateral Surface Area - ' . $this->getLateralSurfaceArea() . PHP_EOL;
        $result .= 'Volume - ' . $this->getVolume();

        return $result;
    }

}