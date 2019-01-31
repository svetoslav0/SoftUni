<?php
$sortedLines = null;
if (isset($_GET['lines'])){
    $input = array_filter(array_map('trim', explode(PHP_EOL, $_GET['lines'])));
    sort($input, SORT_STRING);
    $sortedLines = implode(PHP_EOL, $input);

}

?>

<form>
  <textarea rows="10" name="lines"><?= $sortedLines ?></textarea> <br>
    <input type="submit" name="sort" value="Sort">
</form>
