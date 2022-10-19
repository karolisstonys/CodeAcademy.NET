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


















