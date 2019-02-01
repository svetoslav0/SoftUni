function assign([key1, value1, key2, value2, key3, value3]){
    let result = {};
    result[key1] = value1;
    result[key2] = value2;
    result[key3] = value3;
    return result;
}

console.log(assign(['ssid', '90127461', 'status', 'admin', 'expires', '600']));