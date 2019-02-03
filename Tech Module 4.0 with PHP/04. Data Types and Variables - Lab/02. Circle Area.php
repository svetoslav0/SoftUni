<?php

$radius = doubleval(readline());

$area = $radius * $radius * pi();
echo number_format($area, 12, '.', '');