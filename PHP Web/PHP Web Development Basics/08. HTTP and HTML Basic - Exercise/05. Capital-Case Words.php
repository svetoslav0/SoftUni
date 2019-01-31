<?php
$extracted = null;
if (isset($_GET['text'])){
    $input = $_GET['text'];
    $replaced = str_replace(['.', ','], ' ', $input);
    $arr = array_filter(array_map('trim', explode(' ', $replaced)));
    $extractedArr = [];
    foreach ($arr as $item) {
        if ($item == strtoupper($item)){
            $extractedArr[] = $item;
        }
    }
    $extracted = implode(', ', $extractedArr);

}

?>

<form>
    <textarea rows="10" name="text"><?= $extracted ?></textarea><br>
    <input type="submit" value="Extract">
</form>
