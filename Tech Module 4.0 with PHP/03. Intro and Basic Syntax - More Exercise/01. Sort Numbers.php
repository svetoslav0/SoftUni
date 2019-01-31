<?php

$arr[] = doubleval(readline());
$arr[] = doubleval(readline());
$arr[] = doubleval(readline());

rsort($arr);

echo implode(PHP_EOL, $arr);