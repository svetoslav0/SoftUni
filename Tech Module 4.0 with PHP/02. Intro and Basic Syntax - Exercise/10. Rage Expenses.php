<?php

$lostGames = intval(readline());
$headsetPrice = doubleval(readline());
$mousePrice = doubleval(readline());
$keyboardPrice = doubleval(readline());
$displayPrice = doubleval(readline());

$headsetCount = floor($lostGames / 2);
$mouseCount = floor($lostGames / 3);
$keyboardCount = floor($lostGames / 6);
$displayCount = floor($lostGames / 12);

$totalMoney = $headsetPrice * $headsetCount + $mousePrice * $mouseCount +
                $keyboardPrice * $keyboardCount + $displayPrice * $displayCount;

echo 'Rage expenses: ' . number_format($totalMoney, 2, '.', '') . ' lv.';