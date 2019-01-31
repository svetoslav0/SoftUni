<?php

interface ISpy
{
    /**
     * @return string
     */
    public function getCodeNumber(): string;

    /**
     * @param int $codeNumber
     */
    public function setCodeNumber(int $codeNumber): void;
}