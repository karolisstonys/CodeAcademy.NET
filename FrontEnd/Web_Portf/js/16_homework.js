// TASK 1 ====================================================================

const hw_4_task1_all_functions = () => {
    // --------------- a ---------------
    hw_4_task1a_sync.innerHTML += '<br>sync text nr.1';

    const hw_4_task1_async_add_text = () => {
        let i = 2;
        const interval = setInterval(() => {
            hw_4_task1a_async.innerHTML += `<br>async text nr.${i}`;
            i++;
            if (i === 5) clearInterval(interval);
        }, 2000);
    }

    hw_4_task1_async_add_text();
    hw_4_task1a_sync.innerHTML += '<br>sync text nr.5';
    hw_4_task1a_sync.innerHTML += '<br>sync text nr.6';

    // --------------- b ---------------

    hw_4_task1b_sync.innerHTML += '<br>sync text nr.7';

    let j = 8;
    const hw_4_task1_fakePromise = () => {
        return new Promise((resolve, reject) => {
            setTimeout(() => {
                j++;
                if (true)
                    resolve(hw_4_task1b_async.innerHTML += `<br>async text nr.${j}`);
            }, 5000)
        });
    }

    hw_4_task1_fakePromise();
    hw_4_task1_fakePromise();
    hw_4_task1_fakePromise();

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

const hw_4_task2_all_sync_functions = () => {
    hw_4_task2_p.innerHTML = "This is a paragraph's text added with synchronous function.";
    alert(hw_4_task2_p.innerHTML);
    hw_4_task2_p.style.color = 'red';
};

const hw_4_task2_add_p_text = () => {
    hw_4_task2_p.innerHTML = "This is a paragraph's text added with asynchronous function.";
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

hw_4_task2_sync_button.addEventListener('click', hw_4_task2_all_sync_functions);
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










