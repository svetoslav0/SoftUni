<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Jan-19
 * Time: 10:25 PM
 */

abstract class Characters
{
    /**
     * @var string
     */
    protected $username;

    /**
     * @var string
     */
    protected $password;

    /**
     * @var int
     */
    protected $level;

    /**
     * Characters constructor.
     * @param string $username
     * @param int $level
     */
    public function __construct(string $username, int $level)
    {
        $this->setUsername($username);
        $this->setLevel($level);
    }

    /**
     * @return string
     */
    public function getUsername(): string
    {
        return $this->username;
    }

    /**
     * @param string $username
     */
    public function setUsername(string $username): void
    {
        $this->username = $username;
    }

    /**
     * @return string
     */
    public function getPassword(): string
    {
        return $this->password;
    }

    protected abstract function generatePassword() : void;

    /**
     * @return int
     */
    public function getLevel(): int
    {
        return $this->level;
    }

    /**
     * @param int $level
     */
    public function setLevel(int $level): void
    {
        $this->level = $level;
    }
}