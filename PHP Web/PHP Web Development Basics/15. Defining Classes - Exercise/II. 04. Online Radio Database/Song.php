<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Dec-18
 * Time: 6:03 PM
 */

class Song
{
    /**
     * @var string
     */
    private $name;

    /**
     * @var string
     */
    private $artist;

    /**
     * @var int
     */
    private $minutes;

    /**
     * @var int
     */
    private $seconds;

    /**
     * Song constructor.
     * @param string $name
     * @param string $artist
     * @param int $minutes
     * @param int $seconds
     * @throws Exception
     */
    public function __construct(string $artist, string $name, int $minutes, int $seconds)
    {
        $this->setArtist($artist);
        $this->setName($name);
        $this->setMinutes($minutes);
        $this->setSeconds($seconds);
    }

    /**
     * @return string
     */
    public function getName(): string
    {
        return $this->name;
    }

    /**
     * @param string $name
     * @throws Exception
     */
    public function setName(string $name): void
    {
        if (strlen($name) < 3 || strlen($name) > 30){
            throw new Exception('Song name should be between 3 and 30 symbols.');
        }
        $this->name = $name;
    }

    /**
     * @return string
     */
    public function getArtist(): string
    {
        return $this->artist;
    }

    /**
     * @param string $artist
     * @throws Exception
     */
    public function setArtist(string $artist): void
    {
        if (strlen($artist) < 3 || strlen($artist) > 20){
            throw new Exception('Artist name should be between 3 and 20 symbols.');
        }
        $this->artist = $artist;
    }

    /**
     * @return int
     */
    public function getMinutes(): int
    {
        return $this->minutes;
    }

    /**
     * @param int $minutes
     * @throws Exception
     */
    public function setMinutes(int $minutes): void
    {
        if ($minutes > 14 || $minutes < 0){
            throw new Exception('Song minutes should be between 0 and 14.');
        }
        $this->minutes = $minutes;
    }

    /**
     * @return int
     */
    public function getSeconds(): int
    {
        return $this->seconds;
    }

    /**
     * @param int $seconds
     * @throws Exception
     */
    public function setSeconds(int $seconds): void
    {
        if ($seconds < 0 || $seconds > 59){
            throw new Exception('Song seconds should be between 0 and 59.');
        }
        $this->seconds = $seconds;
    }

    /**
     * @param $totalSeconds
     * @return string
     */
    public static function getTotalTime($totalSeconds) : string
    {
        $hours = floor($totalSeconds / 3600);
        $totalSeconds -= $hours * 3600;
        $minutes = floor($totalSeconds / 60);
        $seconds = $totalSeconds - $minutes * 60;

        $minutes = str_pad($minutes, 2, '0', STR_PAD_LEFT);
        $seconds = str_pad($seconds, 2, '0', STR_PAD_LEFT);

        return "Playlist length: {$hours}h {$minutes}m {$seconds}s";
    }
}