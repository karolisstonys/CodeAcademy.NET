// TASK 1 ====================================================================

const hw_4_task1_all_functions = () => {
    // --------------- a ---------------

    const hw_4_task1_async_add_text = () => {
        let i = 2;
        const interval = setInterval(() => {
            hw_4_task1a_async.innerHTML += `<br>async text nr.${i}`;
            i++;
        }, 2000, 3);
    }

    hw_4_task1a_sync.innerHTML += '<br>sync text nr.1';
    hw_4_task1_async_add_text();
    hw_4_task1a_sync.innerHTML += '<br>sync text nr.5';
    hw_4_task1a_sync.innerHTML += '<br>sync text nr.6';

    // --------------- b ---------------


    let j = 8;
    const hw_4_task1_fakePromise = () => {
        new Promise((resolve, reject) => {
            setTimeout(() => {
                resolve(hw_4_task1b_async.innerHTML += `<br>async text nr.${j}`);
                j++;
            }, 5000)
        });
    }

    hw_4_task1b_sync.innerHTML += '<br>sync text nr.7';
    hw_4_task1_fakePromise();   // 8
    hw_4_task1_fakePromise();   // 9
    hw_4_task1_fakePromise();   // 10
    hw_4_task1b_sync.innerHTML += '<br>sync text nr.11';
    hw_4_task1b_sync.innerHTML += '<br>sync text nr.12';

    // --------------- c ---------------

    let hw_4_task1_containers = document.getElementsByClassName('hw_4_task1_container');
    let last_hw_4_task1_container = hw_4_task1_containers[hw_4_task1_containers.length - 1];

    last_hw_4_task1_container.innerHTML += "<br>Hello World (nr.13)";

    setTimeout(() => {
        last_hw_4_task1_container.innerHTML += "<br>Is this the real end? (nr.14)";
    }, 7000);

    last_hw_4_task1_container.innerHTML += "<br>The End ? (nr.15)";

};

hw_4_task1_button.addEventListener('click', hw_4_task1_all_functions);

// TASK 2 ====================================================================

//const hw_4_task2_all_sync_functions = () => {
hw_4_task2_p.innerHTML = "This is a paragraph's text added with Synchronous function.";
//alert(hw_4_task2_p.innerHTML);
hw_4_task2_p.style.color = 'red';
//};

const hw_4_task2_add_p_text = () => {
    hw_4_task2_p.innerHTML = "This is a paragraph's text added with Asynchronous function.";
};

const hw_4_task2_alert = () => {
    alert(hw_4_task2_p.innerHTML);
};
const hw_4_task2_change_p_color = () => {
    hw_4_task2_p.style.color = 'blue';
};

const hw_4_task2_all_async_functions = () => {
    hw_4_task2_add_p_text();
    hw_4_task2_alert();
    hw_4_task2_change_p_color();
};

//hw_4_task2_sync_button.addEventListener('click', hw_4_task2_all_sync_functions);
hw_4_task2_async_button.addEventListener('click', hw_4_task2_all_async_functions);

// TASK 3 ====================================================================

const hw_4_fill_pizza = (text) => {
    hw_4_task3_textarea.value = `${text}`;
}

let hw_4_all_pizza_ingredients = [];
const hw_4_set_all_pizza_ingredients = () => {
    hw_4_all_pizza_ingredients = [];
    hw_4_all_pizza_ingredients = hw_4_task3_textarea.value.split(',');
    hw_4_task3_ingredient_list.innerHTML = '';
    hw_4_check_ingredients(hw_4_all_pizza_ingredients)
        .then((result) => {
            hw_4_task3_ingredient_list.innerHTML += `<h2>${result}</h2>`;
        })
        .catch((result) => {
            hw_4_task3_ingredient_list.innerHTML += `<h2>${result}</h2>`;
        });
};

const hw_4_check_ingredients = (ingredients) => {
    return new Promise(function (resolve, reject) {
        if (hw_4_task3_textarea.value === '') return reject('No pizza. Sad! =(');
        for (let ingredient of ingredients) {
            if (ingredient.includes(hw_4_task3_textbox.value)) {
                hw_4_task3_ingredient_list.innerHTML += `<p>${ingredient.trimStart().trimEnd()} ❌</p>`;
                return reject(`Sorry, but I do not like ${hw_4_task3_textbox.value}! `);
            }
            else {
                hw_4_task3_ingredient_list.innerHTML += `<p>${ingredient.trimStart().trimEnd()} ✔️</p>`;
            }
        }
        return resolve('That is a tasty pizza!');
    });
}

hw_4_task3_check_pizza_ingredients.addEventListener('click', hw_4_set_all_pizza_ingredients);


// TASK 4 ====================================================================

let currentDate = new Date();
let hours = currentDate.getHours();
let minutes = currentDate.getMinutes();
let seconds = currentDate.getSeconds();

const runTime = () => {
    if (seconds < 59)
        seconds++
    else {
        seconds = 0
        if (minutes < 59)
            minutes++
        else {
            minutes = 0
            if (hours < 23)
                hours++
            else {
                hours = 0
            }
        }
    }
};


const clock = setInterval(() => {
    hw4_task4_clock.innerHTML = `${hours < 10 ? "0" + hours : hours}:${minutes < 10 ? "0" + minutes : minutes}:${seconds < 10 ? "0" + seconds : seconds}`
    runTime();
}, 1000);

/*
let clock = document.getElementById('clock');
let timer = null;

clock.addEventListener("click", function(){
  if(timer !== null){
    clearInterval(timer);
    timer = null;
  } else {
    timer = setInterval(runClock, 1000);
  }
});

timer = setInterval(runClock, 1000);

function runClock() {
    clock.textContent = new Date().toLocaleTimeString();            
}
*/




/* <p id="hw4_task4_clock"></p>
    <button id="hw4_task4_stop">Stop</button>
    <button id="hw4_task4_print">Print Stop TimeTable</button>
    <button id="hw4_task4_strat">Start</button>
    <div id="hw4_task4_timetable"></div> */








