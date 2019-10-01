function wordsUppercase(input) {
    let words = input.replace(/(\W+)/g, ' ').split(' ');
    let filtered = words.filter(function (element) {
        return element != '';
    });
    let mapped = filtered.map(word => word.toUpperCase());
    console.log(mapped.join(", "));
}

wordsUppercase("hello");