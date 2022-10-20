let students = [];
let students2 = new Array();

let colors = ['red', 'orange', 'green'];
let colors2 = new Array('red', 'orange', 'green');

let stuff = [NaN, 65, true, "dog"];
let lastOfTheStuff = stuff[stuff.length - 1];





// TASK 1 --------------------------------------------------------------
console.log(`----------------------- TASK 1 -----------------------`);
let movies = ['Black Adam',                         //
    'Black Panther: Wakanda Forever',               //
    'Avatar: The Way of Water',                     //
    'Ant-Man and the Wasp: Quantumania',            //
    'Shazam! Fury of the Gods'];                    //
for (let movie of movies) {                         //
    console.log(movie)                              //
}                                                   //
// END OF TASK 1 ======================================================= END!





// TASK 2 --------------------------------------------------------------
console.log(`----------------------- TASK 2 -----------------------`);
console.log(`Filmu PRIES pridejima: ${movies.length}`);

movies[movies.length] = 'another movie'
console.log(`Filmu PO pridejima: ${movies.length}`);

for (let movie of movies) {
    console.log(movie)
}
// END OF TASK 2 ======================================================= END!





// TASK 3 --------------------------------------------------------------
console.log(`----------------------- TASK 3 a ---------------------`);
let animalArray = ['dog', 'cat', 'pig', 'cow', 'frog', 'fox', 'horse']

for (let i = 0; i < animalArray.length; i++) {
    console.log(animalArray[i]);

}

console.log(`----------------------- TASK 3 b ---------------------`);
animalArray.sort();
for (let animal of animalArray) {
    console.log(animal);
}
// END OF TASK 3 ======================================================= END!




// TASK 3.1 ------------------------------------------------------------
console.log(`----------------------- TASK 3.1 ---------------------`);


// ...
// ...
// ...


// END OF TASK 3.1 ===================================================== END!



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////  F U N K C I J O S  /////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// BASICS

function helloworld() {
    console.log("Hello World!");
}

for (let i = 0; i < 10; i++) {
    helloworld();
}

// MATH FUNKCIJOS

let mathPi = Math.PI;
let mathValueRound = Math.round(12.698);


function dice() {
    let roll = Math.floor(Math.random() * 6) + 1;
    console.log(`Die was rolled: ${roll}`);
}



function throwDice() {
    dice();
}

function throwDice(count) {
    for (let i = 0; i < count; i++) {
        dice();
    }
}



// FUNCTIONS WITH ARGUMENTS
console.log('hello'.toUpperCase());
console.log('hello'.indexOf('l'));

function greet(name) {
    console.log(`Hello ${name}!`);
    console.log(`Nice to meet you!`);
}

greet();
greet(null);
greet('Edvinas');

function throwDice(numRolls) {
    for (let i = 0; i < numRolls; i++) {
        //throwDie();
    }
}

throwDice(5); // Plain JS does not support overloading

function square(num) {
    console.log(num * num);
}

square(9);

function sum(firstNumber, secondNumber) {
    console.log(firstNumber + secondNumber);
}

sum(8, 9);

function divide(firstNumber, secondNumber) {
    console.log(firstNumber / secondNumber);
}

divide(10, 3);




// FUNCTIONS RETURNING VALUES 
const yell = "welcome".toUpperCase();
console.log(yell);

function sumReturn(firstNumber, secondNumber) {
    return firstNumber + secondNumber;
}

console.log(sumReturn(87, 56));

function sumBrokenReturn(firstNumber, secondNumber) {
    return firstNumber + secondNumber;
    console.log(firstNumber + secondNumber); // Neigyvendina sios dalies, nes jau grazinta reiksme
}

function sumTextReturn(firstNumber, secondNumber) {
    return `Sum: ${firstNumber + secondNumber}`;
}

console.log(sumTextReturn(78, 89));

function isGreen(color) {
    if (color.toLowerCase() === 'green') {
        return true;
    }
    else {
        return false;
    }
}

console.log(`isGreen: ${isGreen('Green')}`);
console.log(`isGreen: ${isGreen('Blue')}`);

function isBetterGreen(color) {
    if (color.toLowerCase() === 'green') {
        return true;
    }

    return false;
}

function isBestGreen(color) {
    return color.toLowerCase() === 'green';
}

function containGreen(arr) {
    for (let color of arr) {
        if (color.toLowerCase() === 'green' || color.toLowerCase() === 'lime') {
            return true;
        }
        // return false;
    }

    return false;
}

let colorArr = ['Pink', 'Blue', 'Green'];

console.log(`Contains green: ${containGreen(colorArr)}`);





// SCOPE
// Function scope
function scopeExample() {
    let scopeName = "Example scope";
    const creationDate = Date.UTC();
    var tag = "Learning";
    console.log(tag);
}

// console.log(tag); // Not possible to access direct function scope

scopeExample();



// Block scope
let animal1 = 'Dog';

function PrintAnimal1() { // Function scope opens
    let animal1 = 'Cat';
    console.log(animal1);

    if (true) { // Block scope opens
        var animal2 = "Owl"; // var is scoped only to functions
        console.log(animal2);
    }
}

PrintAnimal1();
console.log(animal1);



if (true) { // Block scope opens
    var animal2 = "Owl"; // var is scoped only to functions
    console.log(animal2);
}

console.log(`Outer animal2 call: ${animal2}`);

var animals = ["Bear", "Deer", "Zebra"];

var i = 10;
for (var i = 0; i < animals.length; i++) { // Block scope opens
    console.log(i, animals[i]);
}

console.log(i); // With let - 10 if with var - 3


function doubleEleInArray(arr) {
    const result = [];
    for (let num of arr) {
        let double = num * 2;
        result[result.length] = double;
    }

    return result;
}

let doubleNumbersArr = [5, 8, 9, 7, 4, 7];
console.log(doubleEleInArray(doubleNumbersArr));



// Lexical scope
function outer() {
    let movie = 'Amadeus';

    function inner() {
        console.log(movie.toUpperCase());

        function extraInner() {
            console.log(movie.toUpperCase());
        }

        extraInner();
    }

    inner();
}

outer();







// FUNCTION EXPRESSIONS
// Functions are objects
console.dir(sum);

// Annonymous
const sumAnnon = function (a, b) {
    return a + b;
}

console.log(sumAnnon(5, 5));


// Named
const product = function multiplyNamed(a, b) {
    return a * b;
}

console.log(product(5, 5));




// HIGHER ORDER FUNCTIONS
// Tai yra funkcijos, kurios priima funkcijas kaip parametrus arba gražina funkcijas kaip return value


function addFtion(a, b) {
    return a + b;
}

const substractFtion = function (a, b) {
    return a - b;
}

function multiplyFtion(a, b) {
    return a * b;
}

const divideFtion = function (a, b) {
    return a / b;
}

const operations = [addFtion, substractFtion, multiplyFtion, divideFtion];

// console.log(operations[0]);
// console.log(operations[0](100,4));

for (let func of operations) {
    let result = func(50, 8);
    console.log(result);
}

// Class in JS gets added with a function
const thing = {
    //aaa: 'asdas',
    doSomething: multiplyFtion
}

console.log(thing.doSomething(70, 8));

console.log("asd".toUpperCase());
console.log("asd".indexOf("d"));

// FUNCTION AS PARAMETER
function callThreeTimes(func) {
    func();
    func();
    func();
}

function callGeneric() {
    console.log("Generic call");
}

function callMoreGeneric() {
    console.log("More generic call");
}

callThreeTimes(callGeneric);
callThreeTimes(callMoreGeneric);

// Funkcijos deklaravimas
function repeatNTimes(action, num) {
    for (let i = 0; i < num; i++) {
        action();
    }
}

repeatNTimes(callGeneric, 5);


function pickOne(f1, f2) {
    let rand = Math.random();
    console.log(rand);
    if (rand < 0.5) {
        f1();
    }
    else {
        f2();
    }
}

pickOne(callGeneric, callMoreGeneric);






// TASK 4 --------------------------------------------------------------
function getPersonData() {
    let vardas = window.prompt('vardas?', '');
    let pavarde = window.prompt('pavarde?', '');
    let amzius = window.prompt('amzius?', '');
    let elpastas = window.prompt('el.pastas?', '');

    console.log(vardas);
    console.log(pavarde);
    console.log(amzius);
    console.log(elpastas);
}
//getPersonData();
// END OF TASK 4 ======================================================= END!





// TASK 5+6 --------------------------------------------------------------
function isMoreThan18(a) {
    return a >= 18;
}

//let age = prompt('Amzius?');

//buy();

/*function buy() {
    if (isMoreThan18(age)) {
        allGood();
    }
    else {
        if (confirm("Ar turite tevu leidima?") === true) {
            allGood();
        } else {
            goBackToKinderGarten();
        }
    }
}*/

function buy() {
    return (isMoreThan18(age) ? allGood() : (confirm("Ar turite tevu leidima?") ? allGood() : goBackToKindergarten()));
}

function allGood() {
    alert('Pirkimas galimas');
}

function goBackToKindergarten() {
    alert('Pirkimas NEGALIMAS!!!');
}
// END OF TASK 5+6 ======================================================= END!



// TASK 6.1 --------------------------------------------------------------
let metai = prompt('Metai?');

arKeliamiejiMetai(metai);


function arKeliamiejiMetai(metai) {
    if (metai % 4 === 0 || metai % 100 === 0 || metai % 400 === 0) {    // buvo bloga salyga ... =(
        return alert('O taip!')
    }
    return alert('Ne')
}
// END OF TASK 6.1 ======================================================= END!