<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 16-Nov-18
 * Time: 12:15 PM
 */

class Dough
{
    const WHITE_MODIFIER = 1.5;
    const WHOLEGRAIN_MODIFIER = 1;
    const CRISPY_MODIFIER = 0.9;
    const CHEWY_MODIFIER = 1.1;
    const HOMEMADE_MODIFIER = 1;

    /**
     * @var string
     * 'white' or 'wholegrain'
     */
    private $flourType;

    /**
     * @var string
     * 'crispy', 'chewy' or 'homemade'
     */
    private $backingTechnique;

    /**
     * @var float
     */
    private $weight;

    /**
     * Dough constructor.
     * @param string $flourType
     * @param string $bakingTechnique
     * @param float $weight
     * @throws Exception
     */
    public function __construct(string $flourType, string $bakingTechnique, float $weight)
    {
        $this->setFlourType($flourType);
        $this->setBakingTechnique($bakingTechnique);
        $this->setWeight($weight);
    }

    /**
     * @return string
     */
    private function getFlourType(): string
    {
        return $this->flourType;
    }

    /**
     * @param string $flourType
     * @throws Exception
     */
    private function setFlourType(string $flourType): void
    {
        $flour_types = ['white', 'wholegrain'];
        if (!in_array(strtolower($flourType), $flour_types)){
            throw new Exception('Invalid type of dough.');
        }
        $this->flourType = $flourType;
    }

    /**
     * @return string
     */
    private function getBackingTechnique(): string
    {
        return $this->backingTechnique;
    }

    /**
     * @param string $bakingTechnique
     * @throws Exception
     */
    private function setBakingTechnique(string $bakingTechnique): void
    {
        $baking_types = ['crispy', 'chewy', 'homemade'];
        if (!in_array(strtolower($bakingTechnique), $baking_types)){
            throw new Exception('Invalid type of dough.');
        }
        $this->backingTechnique = $bakingTechnique;
    }

    /**
     * @return float
     */
    private function getWeight(): float
    {
        return $this->weight;
    }

    /**
     * @param float $weight
     * @throws Exception
     */
    private function setWeight(float $weight): void
    {
        if ($weight < 1 || $weight > 200){
            throw new Exception('Dough weight should be in the range [1..200]');
        }
        $this->weight = $weight;
    }

    public function getCalories() : float{
        $flour_modifier = '';
        $technique_modifier = '';

        //'white' or 'wholegrain'
        switch (strtolower($this->getFlourType())){
            case 'white':
                $flour_modifier = self::WHITE_MODIFIER;
                break;
            case 'wholegrain':
                $flour_modifier = self::WHOLEGRAIN_MODIFIER;
                break;
        }

        // 'crispy', 'chewy' or 'homemade'
        switch (strtolower($this->getBackingTechnique())){
            case 'crispy':
                $technique_modifier = self::CRISPY_MODIFIER;
                break;
            case 'chewy':
                $technique_modifier = self::CHEWY_MODIFIER;
                break;
            case 'homemade':
                $technique_modifier = self::HOMEMADE_MODIFIER;
        }

        $calories = 2 * $this->getWeight() * $flour_modifier * $technique_modifier;
        return number_format($calories, 2, '.', '');
    }

}