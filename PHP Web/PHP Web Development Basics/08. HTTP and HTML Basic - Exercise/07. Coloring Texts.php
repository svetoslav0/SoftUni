<form>
    <textarea name="input" rows="5" cols="30"></textarea><br />
    <input type="submit" name="submit" value="Color text" />
</form>

<?php
if (isset($_GET['input'])){
    $input = $_GET['input'];
    $charArray = array_filter(str_split($input), function($v){
        return $v != ' ';
    });

    foreach ($charArray as $char) {
        $asciiValue = ord($char);
        if ($asciiValue % 2 == 0){
            echo "<span style=\"color:red\">$char</span> ";
        }else{
            echo "<span style=\"color:blue\">$char</span> ";
        }
    }
}
