//local storage vs. session storage
//localStorage - stores data with no expiration date
//sessionStorage - stores data for one session (data is lost when the browser tab is closed)


//btoa vs. atob
const encodedData = btoa('Hello, world'); // encode a string
const decodedData = atob(encodedData); // decode the string
console.log(encodedData);
console.log(decodedData);


//cookie
document.cookie = "username=John Doe; expires=Thu,13 Jun 2022 12:00:00 UTC; path=/"; 
console.log(document.cookie);

//get current date and time
var currentDate = new Date();
console.log(currentDate);

//XMLHttpRequest
var oReq = new XMLHttpRequest();
oReq.addEventListener("load", reqListener);
oReq.open("GET", "http://jsonplaceholder.typicode.com/posts/1");
oReq.send();
function reqListener(){
    console.log(this.responseText)
}

var oReq = new XMLHttpRequest();
oReq.addEventListener("load", reqListener);
oReq.open("POST", "http://jsonplaceholder.typicode.com/posts");
oReq.send("title=Example POST Request&body=Antra.com&userId=1");
function reqListener(){
    console.log(this.responseText)
}


//Promises: a callback function to intialize this process that takes in two argumenta: resolve and reject:
//1. resolved, the resource was loaded sucessfully/promise excuted successfully
//2. rejected, meant the resource failed to load/promise failed to excute properly

//both of these return something, so the order of resolve or reject matters.
//Callback: is essentially a function that is passed in as a parameter
function promiseDemo(){
    let p = new Promise(function (resolve, reject){
        let dept={id:1, name:"Full Stack"};
        resolve(dept);
        reject("The service is currently unavailable")
    })
    p.then(function(d){
        console.log(d)
    }).catch(function(e){
        console.log(e)
    })
}
promiseDemo()


let p2 = new Promise((resolve,reject)=>{
    resolve(2);
})
p2.then(function(d){
    console.log(d);
    return d*2;
}).then(function(d){
    console.log(d);
    return d*2;
}).then(function(d){
    console.log(d);
})

//Fetch API
// Getting a Resource
fetch("http://jsonplaceholder.typicode.com/posts/1")
.then((response)=>response.json())
.then((json)=>console.log(json))