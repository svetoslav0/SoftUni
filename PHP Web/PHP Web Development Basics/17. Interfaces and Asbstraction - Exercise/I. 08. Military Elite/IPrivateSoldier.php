<?php

interface IPrivateSoldier
{
    /**
     * @return float
     */
    public function getSalary(): float;

    /**
     * @param float $salary
     */
    public function setSalary(float $salary): void;
}