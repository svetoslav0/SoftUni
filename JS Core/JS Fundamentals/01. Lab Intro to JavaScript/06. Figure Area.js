function area(w1, h1, w2, h2){
    let s1 = w1 * h1;
    let s2 = w2 * h2;
    let s3 = Math.min(w1, w2) * Math.min(h1, h2);
    let area = s1 + s2 - s3;
    console.log(area);
}

area(1, 1.01, 1, 1);