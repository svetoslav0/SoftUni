<?php

$games = [
    'OutFall 4' => 39.99,
    'CS: OG' => 15.99,
    'Zplinter Zell' => 19.99,
    'Honored 2' => 59.99,
    'RoverWatch' => 29.99,
    'RoverWatch Origins Edition' => 39.99
];

$balance = doubleval(readline());
$spend = 0;
while (true){
    $currentLine = readline();
    if ($currentLine == 'Game Time'){
        break;
    }
    if (!array_key_exists($currentLine, $games)){
        echo 'Not Found' . PHP_EOL;
        continue;
    }

    $currentGame = $currentLine;
    $currentPrice = $games[$currentGame];

    if ($balance < $currentPrice){
        echo 'Too Expensive' . PHP_EOL;
        continue;
    }

    echo "Bought {$currentGame}" . PHP_EOL;
    $balance -= $currentPrice;
    $spend += $currentPrice;

    if ($balance == 0){
        echo 'Out of money!';
    }
}

if($balance != 0){
    echo 'Total spent: $' . number_format($spend, 2, '.', '') . '. Remaining: $' . number_format($balance, 2, '.','');
}