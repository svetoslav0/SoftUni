<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 21-Sep-18
 * Time: 6:40 PM
 */

$country = readline();

switch ($country){
    case "USA":
    case "England":
        echo "English";
        break;
    case "Spain":
    case "Argentina":
    case "Mexico":
        echo "Spanish";
        break;
    default:
        echo "unknown";
        break;
}