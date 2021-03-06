// 1. 
// We have an object storing salaries of our team
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
}
// Write the code to sum all salaries and store in the variable sum. Should be 390 in the example above.
function SumUp(salaries) {
    var sum = 0;
    for (const key in salaries) {
        sum += salaries[key];
    }
    return sum;
}
console.log(SumUp(salaries));

// 2.
// Create a function multiplyNumeric(obj) that multiplies all numeric properties of obj by 2
// before the call
let menu = {
        width: 200,
        height: 300,
        title:
            "My menu"
    };

function multiplyNumeric(menu) {
    for (const key in menu) {
        if (typeof menu[key] == "number") {
            menu[key] = 2 * menu[key];
        }
    }
}

multiplyNumeric(menu);
console.log(menu);
// after the call
// menu = {
//     width: 400,
//     height: 600,
//     title:
//         "My menu"
// };
// Please note that multiplyNumeric does not need to return anything. It should modify the object in place


// 3.
// Write a function checkEmailId(str) that returns true if str contains '@' and ‘.’, otherwise false. Make sure '@' must come before '.' and there must be some characters between '@' and '.'
// The function must be case-insensitive:
let inputText={
    value: 'alex@ceec.ceom',
}
function ValidateEmail(inputText) {
    var mailFormat =/^[a-zA-Z0-9.! #$%&'*+/=? ^_`{|}~-]+@[a-zA-Z0-9-]+(?:\. [a-zA-Z0-9-]+)*$/;
    if (!inputText.value.match(mailFormat)) {
        return false;
    }
    else {
        return true;
    }
}
console.log(typeof inputText.value);
console.log(ValidateEmail(inputText));
var mailFormat =/^[a-zA-Z0-9.! #$%&'*+/=? ^_`{|}~-]+@[a-zA-Z0-9-]+(?:\. [a-zA-Z0-9-]+)*$/;
var str=" fvcf";
var str1 = "cwvc@ceec.com";
const rvc  = str.match(mailFormat);
console.log(str.match(mailFormat));
console.log(str1.match(mailFormat));


// 4.
// Create a function truncate(str, maxlength) that checks the length of the str and, if it exceeds maxlength –replaces the end of str with the ellipsis character "...", to make its length equal to maxlength.
// The result of the function should be the truncated (if needed) string.
// truncate("What I'd like to tell on this topic is:", 20) = "What I'd like to te..."
// truncate("Hi everyone!", 20) = "Hi everyone!"
function truncate(str, num){
    if (str.length<num){ 
        return str;
    }else{
        return str.split("", num-1).join("") + "...";
    }
}
console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));



// 5.
// Let’s try 5 array operations.
// Create an array styles with items “James” and “Brennie”.
// Append “Robert” to the end.
// Replace the value in the middle by “Calvin”. Your code for finding the middle value should work for any arrays with odd length.
// Remove the first value of the array and show it.
// Prepend Rose and Regal to the array.
// James, Brennie
// James, Brennie, Robert
// James, Calvin, Robert
// Calvin, Robert
// Rose, Regal, Calvin, Robert

const array = ["James", "Brennie"];
console.log(array);
array.push("Robert");
console.log(array);
array[Math.floor(array.length/2)]="Calvin"; //array.length should be odd
console.log(array);
array.splice(0, 1);
console.log(array);
array.splice(0,0,"Rose","Regal");
console.log(array);