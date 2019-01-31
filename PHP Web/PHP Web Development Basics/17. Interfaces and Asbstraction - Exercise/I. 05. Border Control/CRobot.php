<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 05-Jan-19
 * Time: 3:40 PM
 */

class CRobot extends Identifiable
{
    /**
     * @var string
     */
    private $model;

    /**
     * Robot constructor.
     * @param string $model
     * @param string $id
     */
    public function __construct(string $model, string $id)
    {
        $this->setModel($model);
        $this->setId($id);
    }

    /**
     * @return string
     */
    public function getModel(): string
    {
        return $this->model;
    }

    /**
     * @param string $model
     */
    public function setModel(string $model): void
    {
        $this->model = $model;
    }
}