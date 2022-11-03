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
            console.log(friend.name + ' is now doing ' + friend.activity);
        }
    }

}
task2Func('child1');
// END OF TASK 2




// TASK 3
const person = {
    name: 'Rosa',
    age: 120,
    alive: false,
    interests: ['swimming', 'cards']
}

task3Func();
function task3Func() {
    person.name = "The new guy";
    let newAge = Math.floor(Math.random() * 101) + 20;
    person.age = newAge;
    if (newAge < 100) {
        person.alive = true;
        person.interests.push('enjoying life');
    }
    console.log(person.interests)

}

// END OF TASK 3





// TASK 4

const task4Arr = ["I", "study", "JavaScript", "right", "now"];
console.log(task4Arr);
task4Arr.splice(0, 3, "Lets", "dance");
console.log(task4Arr.join(' '));

// END OF TASK 4



// TASK 5

let task5Arr1 = ["slice", "splice", "concat"];
let task5Arr2 = ["pop", "push", "shift", "unshift"];
let task5Arr3 = task5Arr1.concat(task5Arr2)
task5Arr3[task5Arr3.length] = 'length';
task5Arr3[task5Arr3.length] = 7;
task5Arr3[task5Arr3.length] = { subject: 'methods' };
console.log(task5Arr3);

// END OF TASK 5




// TASK 6

let accords = ['D', 'G', 'C', 'C7', 'F'];

function updateAccord(accord) {
    if (!accord.endsWith('7')) {
        accord += '7';
    }
    return accord;
    // console.log(accord);
}

for (let i = 0; i < accords.length; i++) {
    console.log(updateAccord(accords[i]));
}

// END OF TASK 6




// TASK 7
let numbers3 = [5, 1, 7, 2, -9, 8, 2, 7, 9, 4, -5, 2, -6, 8, -4, 6];

const bodyEle = document.querySelector('body');

numbers3.forEach(function (num, ind) {
    bodyEle.innerHTML += `<p>Index Nr: ${ind}, value: ${num}</p>`;
});

bodyEle.innerHTML += `<hr/>`;

for (let i = 0; i < numbers3.length; i++) {
    bodyEle.innerHTML += `<p>Index Nr: ${i}, value: ${numbers3[i]}</p>`;
};

// END OF TASK 7




// TASK 8
function arrDouble(arr) {
    return arr.map(function (arrEle) {
        // We return value to an array that is STILL in progress of being built
        return arrEle * 2;
    });
}

function arrDoubleArrowSyntax(arr) {
    return arr.map(arrEle => arrEle * 2);
}

console.log(arrDouble(numbers3));

function arrMultiplied(arr, multiplier) {
    return arr.map(arrEle => arrEle * multiplier);
}

console.log(arrMultiplied(numbers3, 3));

// END OF TASK 8




// TASK 9

function isPersonInArray(nameArr, lookupName) {
    return nameArr.includes(lookupName)
        ? getGenderBasedGreet(lookupName)
        : `Unfotunately Name is not in our list`;
}

function getGenderBasedGreet(name) {
    // Alternative: can be used with endswith
    let lastChar = name.charAt(name.length - 1); // name[name.length-1]
    if (lastChar === 's') {
        return `Welcome Mr. ${name}`;
    }
    return `Welcome Miss. ${name}`;
}

console.log(isPersonInArray(budgetExercise8, 'Edvinas'));

function arrCountTwos(arr) {
    return arr.filter(n => n === 2).length;
}

console.log(arrCountTwos(numbers3));

// END OF TASK 9



// TASK 10

const names = budgets.map((person) => person.name);
const monies = budgets.map((person) => person.budget);

if (monies.some(n => n < 0)) {
    console.log(`Found a budget account with a negative value.`);
}

function belowHundred(arr) {
    if (arr.some(belowHundredCondition)) {
        return arr.filter(belowHundredCondition);
    }
    return `All numbers are above 100`;
};

function belowHundredCondition(num) {
    return num < 100;
}

console.log(belowHundred(numbers3));

function symbolified(arr) {
    if (arr.every(n => n.length >= 3)) {
        if (arr.some(symbolifiedCondition)) {
            let newArr = arr.filter(symbolifiedCondition);
            return newArr.map(function (ele) {
                return ele.replace('a', '@');
            });
        }
    }
}

function symbolifiedCondition(word) {
    return word.includes('a');
}

console.log(symbolified(budgetExercise8));

// END OF TASK 10