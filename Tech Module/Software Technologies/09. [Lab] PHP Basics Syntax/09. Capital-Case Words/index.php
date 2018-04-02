<?php
    if (isset($_GET['text']))
    {
        $upperWords = [];
        $text = $_GET['text'];
        preg_match_all('/\w+/', $text, $words);
        $words = $words[0];
        for($i = 0; $i < count($words); $i++){
            if ($words[$i] == strtoupper($words[$i])){
                $upperWords[] = $words[$i];
            }
        }
        $text = implode(", ", $upperWords);
    }
?>

<form>
    <textarea rows="10" name="text">
        <?=$text?>
    </textarea> <br>
    <input type="submit" value="Extract">
</form>
