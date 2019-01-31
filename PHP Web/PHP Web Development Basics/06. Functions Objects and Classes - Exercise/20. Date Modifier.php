<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 07-Oct-18
 * Time: 11:40 PM
 */


$date1 = new DateTime();
$date2 = new DateTime();
$date1->format('Y m d');
$date2->format('Y m d');

list($year1, $month1, $day1) = explode(' ', readline());
list($year2, $month2, $day2) = explode(' ', readline());

$date1->setDate($year1, $month1, $day1);
$date2->setDate($year2, $month2, $day2);

$interval = $date1->diff($date2);

echo $interval->format('%a');