<?php

echo "Length: ";
$length = floatval(readline());
echo "Width: ";
$width = floatval(readline());
echo "Height: ";
$height = floatval(readline());
$v = ($length * $width * $height) / 3;
echo sprintf("Pyramid Volume: %.2f", $v) . PHP_EOL;
