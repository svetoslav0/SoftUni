<?php

$totalMoney = 0;

while (true){
    $input = readline();
    if ($input == 'Start'){
        break;
    }

    $coin = doubleval($input);
    if ($coin != 0.1 && $coin != 0.2 && $coin != 0.5 && $coin != 1 && $coin != 2){
        echo "Cannot accept {$coin}" . PHP_EOL;
    } else{
        $totalMoney += $coin;
    }
}

while (true){
    $input = readline();
    if ($input == 'End'){
        break;
    }

    $product = $input;
    if ($product == 'Nuts'){
        if ($totalMoney < 2){
            echo 'Sorry, not enough money' . PHP_EOL;
        }else{
            $totalMoney -= 2;
            echo "Purchased nuts" . PHP_EOL;
        }
    } elseif ($product == 'Water'){
        if ($totalMoney < 0.7){
            echo 'Sorry, not enough money' . PHP_EOL;
        }else{
            $totalMoney -= 0.7;
            echo "Purchased water" . PHP_EOL;
        }
    } elseif ($product == 'Crisps'){
        if ($totalMoney < 1.5){
            echo 'Sorry, not enough money' . PHP_EOL;
        }else{
            $totalMoney -= 1.5;
            echo "Purchased crisps" . PHP_EOL;
        }
    } elseif ($product == 'Soda'){
        if ($totalMoney < 0.7 + 0.1){
            echo 'Sorry, not enough money' . PHP_EOL;
        }else{
            $totalMoney -= 0.7 + 0.1;
            echo "Purchased soda" . PHP_EOL;
        }
    } elseif ($product == 'Coke'){
        if ($totalMoney < 1){
            echo 'Sorry, not enough money' . PHP_EOL;
        }else{
            $totalMoney -= 1;
            echo "Purchased coke" . PHP_EOL;
        }
    } else{
        echo 'Invalid product' . PHP_EOL;
    }
}

echo "Change: " . number_format($totalMoney, 2, '.', '');