<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 15-Nov-18
 * Time: 3:55 PM
 */

spl_autoload_register();

$lineOfPeople = explode(';', readline());
$lineOfProducts = array_filter(explode(';', readline()));



$people = [];
$products = [];

foreach ($lineOfPeople as $person) {
    list($name, $money) = explode('=', $person);
    try{
        $currentPerson = new Person2($name, $money);
    }catch (Exception $e){
        die($e->getMessage());
    }
    $people[$name] = $currentPerson;
}

foreach ($lineOfProducts as $product) {
    list($name, $cost) = explode('=', $product);
    try{
        $currentProduct = new Product($name, $cost);
    }catch (Exception $e){
        die($e->getMessage());
    }
    $products[$name] = $currentProduct;
}


$purchase = readline();
while ($purchase != 'END'){
    list($person, $product) = explode(' ', $purchase);
    $searchedPerson = $people[$person];
    $searchedProduct = $products[$product];

    if ($searchedPerson->getMoney() < $searchedProduct->getCost()){
        echo $searchedPerson->getName() . " can't afford " . $searchedProduct->getName() . PHP_EOL;
        $purchase = readline();
        continue;
    }

    $people[$person]->setMoney($people[$person]->getMoney()-$products[$product]->getCost());
    $bagOfProducts = $people[$person]->getBagOfProducts();
    $bagOfProducts[] = $products[$product];
    $people[$person]->setBagOfProducts($bagOfProducts);

    echo "{$person} bought {$product}" . PHP_EOL;
    $purchase = readline();
}

/**
 * @var $person Person2
 * @var $arrOfProducts Product[]
 */
foreach ($people as $person) {
    echo $person->getName() . ' - ';
    $arrOfProducts = $person->getBagOfProducts();
    $arrOfProductsNames = [];
    foreach ($arrOfProducts as $product) {
        $arrOfProductsNames[] = $product->getName();
    }
    if (empty($arrOfProductsNames)){
        echo "Nothing bought" . PHP_EOL;
    }else{
        echo implode(',', $arrOfProductsNames) . PHP_EOL;
    }
}
