<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 27-Sep-18
 * Time: 2:12 PM
 */

$words = explode(' ', readline());

$words = array_reverse($words);

echo implode(" ", $words);