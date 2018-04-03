<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        table * {
            border: 1px solid black;
            width: 50px;
            height: 50px;
        }
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red
        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
    </tr>
    <?php
    $num = 5;
    $rgb = 51;
    for($i = 1; $i <= $num; $i++){
        echo "<tr>";
        echo "<td style='background-color:rgb($rgb,0,0)'></td>";
        echo "<td style='background-color:rgb(0,$rgb,0)'></td>";
        echo "<td style='background-color: rgb(0,0,$rgb)'></td>";
        $rgb+=51;
        echo "</tr>";
    }
    ?>
</table>
</body>
</html>