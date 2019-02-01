function multiplicationTable(n){
    let num = +n;
    let html = '<table border="1">\n';
    for (let i = 1; i <= num; i++) {
        if (i === 1){
            html += '<tr><th>x</th>';
            for (let k = 1; k <= num; k++) {
                html += `<th>${k}</th>`;
            }
            html += '</tr>\n';
        }
        html += `<tr><th>${i}</th>`;
        for (let j = 1; j <= num; j++) {
            html += `<td>${i * j}</td>`;
        }
        html += '</tr>\n';
    }
    html += '</table>';
    console.log(html);
}

multiplicationTable(5);