let topSongs = [
    "First Song",
    "Second Song",
    "Third Song",
    "Fourth Song",
    "Fifth Song"
];

topSongs[topSongs.length] = "Sixth Song";
topSongs.push("Seventh Song");
topSongs.pop(); // removes last topSong[] item - "Seventh Song"

let dishesToWash = ['big plater'];
dishesToWash.unshift('large plate');
console.log(dishesToWash.unshift('small plate')); // returns dishesToWash.length
dishesToWash.unshift('nug', 'fork', 'knife');
console.log(dishesToWash);

let removedDish = dishesToWash.shift(); // removes 1st element from array and returns it
dishesToWash.shift(); // removes first dishesToWash[] item - "knife"



// CONCAT
// Joins 2 arrays and creates a new array from them both
let fruits = ['apple', 'banana'];
let veggies = ['asparagus', 'bruseel sprouts'];
let meats = ['steak', 'chicken breast'];

let veganFood = fruits.concat(veggies);

console.log(fruits.concat(veggies));
console.log(fruits);
console.log(veggies);
console.log(fruits, veggies);
console.log(veganFood);

let allFood = fruits.concat(veggies, meats);
console.log(allFood);





// INCLUDES AND INDEXOF
// Searches for atleast a single occurance
// Include returns a boolean
// IndexOf returns an integer. If nothing is found returns -1.
let ingredients = [
    'Water',
    'Eel',
    'Corn',
    'Flour',
    'Cheese',
    'Shrimp',
    'Brown sugar',
    'Butter'
];

console.log(ingredients.includes('fish')); // False
console.log(ingredients.includes('Shrimp')); // True
console.log(ingredients.includes('sugar')); // False
console.log(ingredients.includes('Water', 3)); // We start searching from Flour
console.log(ingredients.includes('Cheese', 3));

if (ingredients.includes('Flour')) {
    console.log("I am gluten free, I cannot eat that.");
}

console.log(ingredients.indexOf('Eel'));
console.log(ingredients.indexOf('sugar'));
console.log(ingredients.indexOf('maple syrup'));
console.log(ingredients.indexOf('Cheese', 5)); // Search for Cheese from Shrimp
console.log(ingredients.indexOf('Cheese', 3));

// Truthy or Falsy values
if (ingredients.indexOf('Flour') !== -1) {
    console.log("I am gluten free, I cannot eat that.");
}






// REVERSE AND JOIN
// Reverse - Mutates array
// Join - joins all elements into a single string without mutation
let letters = [
    'T',
    'C',
    'E',
    'P',
    'S',
    'E',
    'R',
];

let randomArrayForReverse = [
    12.3,
    60,
    false
];

console.log(letters);
console.log(letters.reverse()); // Mutates array
console.log(letters);

console.log(letters.join());
console.log(letters.join('&'));
console.log(letters.join('.'));
console.log(letters);

console.log(randomArrayForReverse.join());
console.log(randomArrayForReverse.reverse());
console.log(randomArrayForReverse.join());






// TASK 1
let L14_array1 = ['START']
let L14_textbox = document.getElementById('L14_textbox');
let L14_output = document.getElementById('L14_output');

L14_run_1();
function L14_run_1() {
    L14_output.innerHTML = L14_array1;
}

function L14_push() {
    L14_array1.push(L14_textbox.value);
    L14_run_1();
}

function L14_pop() {
    L14_array1.pop(L14_textbox.value);
    L14_run_1();
}

function L14_unshift() {
    L14_array1.unshift(L14_textbox.value);
    L14_run_1();
}

function L14_shift() {
    L14_array1.shift(L14_textbox.value);
    L14_run_1();
}

// END OF TASK 1












let unsortedLetters = [
    'T',
    't',
    'E',
    'a',
    'S',
    'A',
    'R',
];

console.log(unsortedLetters.sort());








const student = {
    firstName: 'Jonas',
    lastName: 'Jonaitis',
    fullName: function () {
        return this.firstName + " " + this.lastName;
    }
}

student.fullName();

const shoppingCart = [
    {
        product: "Janga1",
        price: 6.99,
        quantity: 1
    },
    {
        product: "Janga2",
        price: 6.99,
        quantity: 1
    },
    {
        product: "Janga3",
        price: 6.99,
        quantity: 1
    },
]





// TASK 2
const task2 = {
    name: "child1",
    toysArray: ['toy1', 'toy2', 'toy3'],
    yearsOld: 6,
    birthday: true,
    totalToys: null,
    friends: [
        {
            name: "friendName1",
            activity: "activity1"
        },
        {
            name: "friendName2",
            activity: "activity2"
        },
        {
            name: "friendName3",
            activity: "activity3"
        },
    ]
}

function task2Func(name) {
    if (task2.name === name && task2.birthday) {
        let birthdayToy = task2.toysArray.shift();
        task2.toysArray.push('New Toy 3000');
        task2.yearsOld++;
        task2.totalToys = task2.toysArray.length;

        for (let friend of task2.friends) {
            console.log(friend.name);
        }
    }

}
task2Func('child1');



// END OF TASK 2
