<?php

$ponds = doubleval(readline());
$dollars = $ponds * 1.31;
echo number_format($dollars, 3, '.', '');