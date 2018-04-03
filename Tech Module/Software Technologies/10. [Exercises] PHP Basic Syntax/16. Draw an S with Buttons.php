
<?php

    $num = 5;

    for ($i = 0; $i < $num; $i++) {
        echo "<button style='background-color: blue;'>1</button>";
    }
    echo "<br>";
    for ($i = 0; $i < $num - 2; $i++) {
        echo "<button style='background-color: blue;'>1</button>";

        for ($j = 0; $j < $num - 1; $j++) {
            echo "<button>0</button>";

        }
        echo "<br>";
    }
    for ($i = 0; $i < $num; $i++) {
        echo "<button style='background-color: blue;'>1</button>";
    }
    echo "<br>";
    for ($i = 0; $i < $num - 2; $i++) {

        for ($j = 0; $j < $num - 1; $j++) {
            echo "<button>0</button>";

        }

        echo "<button style='background-color: blue;'>1</button>";
        echo "<br>";
    }

    for ($i = 0; $i < $num; $i++) {
        echo "<button style='background-color: blue;'>1</button>";

}
?>