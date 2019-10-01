function isPalindrome(word){
    let reversed = word.split('').reverse().join('');
    if(reversed === word){
        return true;
    }
    return false;
}

console.log(isPalindrome('Hello'));