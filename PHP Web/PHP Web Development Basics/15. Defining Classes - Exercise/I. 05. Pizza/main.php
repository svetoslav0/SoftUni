<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 16-Nov-18
 * Time: 5:50 PM
 */

spl_autoload_register();

list($pizza, $pizza_name, $toppings_number) = explode(' ', readline());
list($dough, $flour_type, $baking_technique, $dough_weight) = explode(' ',readline());
$n = $toppings_number;

try {
    $d = new Dough($flour_type, $baking_technique, $dough_weight);
} catch (Exception $e) {
    echo $e->getMessage();
    exit;
}

$toppings = [];
while ($toppings_number-- > 0){
    list($topping, $topping_type, $topping_weight) = explode(' ', readline());
    try {
        $t = new Topping($topping_type, $topping_weight);
        $toppings[] = $t;
    } catch (Exception $e) {
        echo $e->getMessage();
        exit;
    }
}

try {
    $p = new Pizza($pizza_name, $d, $toppings, $n);
    echo $p;
} catch (Exception $e) {
    echo $e->getMessage();
    exit;
}