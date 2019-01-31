<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
    if (isset($_GET['num'])){
        $num = intval($_GET['num']);
        $n1 = 1;
        $n2 = 1;
        $n3 = $n1 + $n2;
        echo "$n1 $n2 $n3 ";
        $currentResult = 1;
        for ($i = 0; $i < $num - 3; $i++){
            $currentResult = $n1 + $n2 + $n3;
            echo "$currentResult ";
            $n1 = $n2;
            $n2 = $n3;
            $n3 = $currentResult;
        }
    }
?>

</body>
</html>