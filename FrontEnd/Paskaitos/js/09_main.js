
console.log(`--------------------------------------  while:`);
let n = 0
while (n < 3) {
    n++;
    console.log(n)
}


console.log(`--------------------------------------  do while:`);
let result = ``;
let i = 0;
do {
    i++;
    result += i;
    console.log(`${i}`);
} while (i < 5)
console.log(`${result}`);


console.log(`--------------------------------------  for:`);
let str = ``;
for (let i = 0; i < 9; i++) {
    str += i;
}
console.log(`${str}`);


console.log(`--------------------------------------  for ... of:`);
let arr = [`a`, `b`, 1, `2`, true];
for (let item of arr) {
    console.log(`${item} - ${typeof item}`);
}


console.log(`--------------------------------------  for ... in:`);
let object = {
    vardas: 'Jonas',
    pavarde: 'Jonaitis',
    amzius: 30,
};
for (let prop in object) {
    console.log(`${prop} : ${object[prop]} - ${typeof object[prop]}`);
}


// --------------------------------------------------------------------
console.log(`--------------------------------------  switch:`);
let date = new Date('1985-02-12');
switch (date.getDay()) {
    case 0:
        day = 'sekmadienis'
        break;
    case 1:
        day = 'pirmadienis'
        break;
    case 2:
        day = 'antradienis'
        break;
    case 3:
        day = 'streciadienis'
        break;
    case 4:
        day = 'ketvirtadienis'
        break;
    case 5:
        day = 'penktadienis'
        break;
    case 6:
        day = 'sestadienis'
        break;
    default:
        day = '';
        break;
}
console.log(day);


// --------------------------------------------------------------------
switch (date.getDay()) {
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        txt = "Darbo diena";
        break;
    case 6:
    case 0:
        txt = 'Savaitgalis'
        break;
    default:
        txt = '';
        break;
}
console.log(txt);

// --------------------------------------------------------------------
let x = '0';
// switch daro === tikrinima , o ne ==
switch (x) {
    case 0:
        jungiklis = "isjungtas";
        break;
    case 1:
        jungiklis = "ijungtas";
        break;
    default:
        jungiklis = "nezinomas";
        break;
}
console.log(jungiklis);


// Uzduotis 3 --------------------------------------------------------------------
console.log(`--------------------------------------  TASK 3 :`);
let task3 = ``;
for (let i = 0; i <= 16; i += 4) {
    task3 = task3 + ' ' + i;
}
console.log(`${task3}`);