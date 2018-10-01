<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 26-Sep-18
 * Time: 12:31 PM
 */


$today = getdate();
$currentHours = $today['hours'];
$currentYear = $today['year'];
$daysToNewYear = 365 - $today['yday'];
if($currentYear % 4 == 0){ // leap
    $daysToNewYear = 366 - $today['yday'];
}
$hoursToNewYear = $daysToNewYear * 24 + 24 - $currentHours;
echo "Hours until new year : $hoursToNewYear";

// not finished!
