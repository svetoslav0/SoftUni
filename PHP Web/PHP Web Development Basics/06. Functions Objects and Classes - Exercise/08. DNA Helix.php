<?php
/**
 * Created by PhpStorm.
 * User: Svetoslav
 * Date: 04-Oct-18
 * Time: 8:59 AM
 */
/* n = 10
**AT**  ------------> 0
*C--G*  ------------> 1
T----T  ------------> 2
*A--G*  ------------> 3
**GG**
*A--T*
C----G
*T--T*
**AG**
*G--G*
*/

$n = intval(readline());
$arr = ['A', 'T', 'C', 'G', 'T', 'T', 'A', 'G', 'G', 'G'];
$arrCount = count($arr);
for($i = 0; $i < 2 * $n; $i += 2){
    //echo "i = $i, (i / 2) % 2 = " . ($i / 2 % 2) . PHP_EOL;
    if (($i / 2) % 4 == 0){
        echo "**" . $arr[$i % $arrCount] . $arr[($i + 1) % $arrCount] . "**" . PHP_EOL; //   ------------> 0
    }elseif(($i / 2) % 4 == 1){
        echo "*" .$arr[$i % $arrCount] . '--' . $arr[($i + 1) % $arrCount] . '*' . PHP_EOL; //   --------> 1
    }elseif(($i / 2) % 4 == 2){
        echo $arr[$i % $arrCount] . '----' . $arr[($i + 1) % $arrCount] . PHP_EOL; //        ------------> 2
    }elseif(($i / 2) % 4 == 3){
        echo "*" .$arr[$i % $arrCount] . '--' . $arr[($i + 1) % $arrCount] . '*' . PHP_EOL; //   --------> 3
    }
}

