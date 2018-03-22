function solve(str) {
    str = str + "";
    let arr = str.split(/\W+/);
    let result = [];
    for(let i = 0; i < arr.length; i++){
        if(arr[i] == arr[i].toUpperCase() && arr[i] != ""){
            result.push(arr[i]);
        }
    }
    result = result.join(", ").trim();
    console.log(result);
}

solve("We start by HTML, CSS, JavaScript, JSON and REST.\n" +
    "Later we touch some PHP, MySQL and SQL.\n" +
    "Later we play with C#, EF, SQL Server and ASP.NET MVC.\n" +
    "Finally, we touch some Java, Hibernate and Spring.MVC.")

