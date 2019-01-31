<form>
    <textarea name="input" rows="5" cols="30"></textarea><br />
    <input type="submit" name="submit" value="Count words" />
</form>


<?php
if (isset($_GET['input'])){
    $words = [];
    $input = $_GET['input'];
    $input = preg_split("/[^A-Za-z]+/", $input, -1, PREG_SPLIT_NO_EMPTY);

    foreach ($input as $word){
        $word = strtolower($word);
        if (!array_key_exists($word, $words)){
            $words[$word] = 0;
        }
        $words[$word]++;
    }

    echo "<table border='2'>";
    foreach ($words as $word => $value) {
        echo "<tr><td>$word</td><td>$value</td></tr>";
    }
    echo "</table>";

}
?>