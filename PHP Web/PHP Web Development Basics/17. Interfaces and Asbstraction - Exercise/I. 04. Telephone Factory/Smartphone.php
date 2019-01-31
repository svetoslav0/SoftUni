<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 03-Jan-19
 * Time: 5:26 PM
 */

class Smartphone implements Browse, Call
{
    public function call(string $numbers) : void
    {
        $numbers_array = explode(' ', $numbers);
        foreach ($numbers_array as $number) {
            if (is_numeric($number)){
                echo 'Calling... ' . $number . PHP_EOL;
            }else{
                echo 'Invalid number!' . PHP_EOL;
            }
        }
    }
    public function browse(string $sites) : void
    {
        $sites_array = explode(' ', $sites);
        foreach ($sites_array as $site) {
            if (!preg_match('#[0-9]#', $site)){
                echo 'Browsing: ' . $site . '!' . PHP_EOL;
            }else{
                echo 'Invalid URL!' . PHP_EOL;
            }
        }
    }
}