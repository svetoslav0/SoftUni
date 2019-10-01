function pointInRectangle([x, y, xMin, xMax, yMin, yMax]){
    if(x > xMax || x < xMin || y > yMax || y < yMin){
        return 'outside';
    }
    return 'inside';
}

console.log(pointInRectangle([8, -1, 2, 12, -3, 3]));