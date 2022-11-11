//JSON.stringify(userObj)
//JSON.parse(userObj)
const user = JSON.parse(localStorage.getItem('USER'));

window.onload = function () {
    if (!user) {
        alert('Jūs nesate prisijungę! Prisijunkite, jei norite tęsti darbą.');
        window.location.href = "index.html";
    };
    if (user) {
        user_id.innerHTML = user.ID;
        user_name.innerHTML = user.FirstName + " " + user.LastName;
        getAllTodosForThisUser();
    };
};

const logout = () => {
    localStorage.clear();
    window.location.href = "index.html";
}
user_logout.addEventListener('click', logout);

///////////////////////////////////////////////////////////////////////////////////////////

const form_new_todo = document.querySelector('#form_new_todo');
const postURL = 'https://testapi.io/api/4seven/resource/Todos';

function createNewTodo() {
    let form = new FormData(form_new_todo);
    let newObject = {};

    form.forEach((value, key) => { newObject[key] = value });
    //newObject['Completed'] = true;
    newObject['UserID'] = user.ID;

    fetch(postURL, {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(newObject)
    })
        .then(res => {
            if (res.ok) {
                console.log(res.json());
                p_message.innerHTML += '<br>Naujas todo sukurtas sekmingai!';
                getAllTodosForThisUser();
            }
            else {
                p_message.innerHTML += '<br>Klaida! - ' + + res.status;
            }
        })
        .catch((err) => p_message.innerHTML += '<br>Todo sukurti nepavyko - ' + err);
}

const form_new_todo_submit = document.querySelector('#form_new_todo_submit');
form_new_todo_submit.addEventListener('click', (e) => {
    e.preventDefault(); // Breaks manual refresh after submit
    createNewTodo();
})

///////////////////////////////////////////////////////////////////////////////////////////

const getURL = 'https://testapi.io/api/4seven/resource/Todos';
const getOptions = {
    method: 'get',
    headers: {
        'Accept': 'application/json, text/plain',
        'Content-Type': 'application/json'
    }
}

const saveToLocalStorage = (obj) => {
    localStorage.setItem('ALL_TODOS', JSON.stringify(obj));
}

const showUserTodos = () => {
    const allUserTodos = JSON.parse(localStorage.getItem('ALL_TODOS'));
    div_all_todo.innerHTML = '';
    for (const todo of allUserTodos) {
        let completed = todo.Completed ? '🗹' : '☐';

        div_all_todo.innerHTML +=
            `<div id="div_todo_${todo.ID}" class="div_todo">` +

            `<div id="div_edit_todo_mask_${todo.ID}" class="div_edit_mask">` +
            `<div><label for="Type">Type:</label><input type="text" id="update_type_${todo.ID}" value="${todo.Type}"></div>` +
            `<div><label for="Content">Content:</label><input type="text" id="update_content_${todo.ID}" value="${todo.Content}"></div>` +
            `<div><label for="EndDate">EndDate:</label><input type="text" id="update_enddate_${todo.ID}" value="${todo.EndDate}"></div>` +
            `<div class="div_edit_mask_buttons">` +
            `<div class="todo_edit_confirm" onclick="confirmEditTodo(${todo.ID})">Saugoti</div>` +
            `<div class="todo_edit_cancel" onclick="cancelEditTodo(${todo.ID})">Atšaukti</div>` +
            `</div></div>` +

            `<div id="div_delete_todo_mask_${todo.ID}" class="div_delete_mask">` +
            `<div>Ištrinti Todo (ID ${todo.ID})?</div>` +
            `<div class="div_delete_mask_buttons">` +
            `<div class="todo_delete_confirm" onclick="confirmDeleteTodo(${todo.ID})">Trinti</div>` +
            `<div class="todo_delete_cancel" onclick="cancelDeleteTodo(${todo.ID})">Atšaukti</div>` +
            `</div></div>` +

            `<div class="todo_header">` +
            `<div class="todo_header_left">` +
            `<div>${completed}</div>` +
            `<div class="todo_enddate">${todo.EndDate}</div>` +
            `</div><div class="todo_header_right">` +
            `<div class="todo_icon" title="Įvykdyti">✔️</div>` +
            `<div class="todo_icon" title="Redaguoti" onclick="editTodo(${todo.ID})">✏️</div>` +
            `<div class="todo_icon" title="Trinti" onclick="deleteTodo(${todo.ID})">🗑️</div>` +
            `</div></div>` +

            `<div class="todo_type">${todo.Type}</div>` +
            `<div class="todo_content">${todo.Content}</div>` +
            `<div class="todo_footer"><div class="todo_icon" title="Sukurta: ${todo.Created}">Sukurta: ${todo.Created}</div>` +
            `<div class="todo_icon" title="Atnaujinta: ${todo.Updated}">Atnaujinta: ${todo.Updated}</div></div>` +
            `</div>`;

        //p_message.innerHTML += `<br>[${todo.ID}] ${todo.Completed} ${todo.Type} ${todo.Content} ${todo.EndDate} [${todo.Created}] [${todo.Updated}]`;
    }
}

const getAllTodosForThisUser = () => {
    fetch(getURL, getOptions)
        .then(obj => obj.json())
        .then(userTodoData => {
            console.log(userTodoData);
            const userTodosArr = [];

            for (const todo of userTodoData.data) {
                if (todo.UserID === user.ID) {
                    userTodosArr.push({
                        ID: todo.id,
                        Completed: todo.Completed,
                        Type: todo.Type,
                        Content: todo.Content,
                        EndDate: todo.EndDate,
                        Created: todo.createdAt.slice(0, 10) + ' ' + todo.createdAt.slice(11, 19),
                        Updated: todo.updatedAt.slice(0, 10) + ' ' + todo.updatedAt.slice(11, 19)
                    });
                }
            }

            saveToLocalStorage(userTodosArr)
            showUserTodos();
        })
        .catch((err) => p_message.innerHTML = err);
}

///////////////////////////////////////////////////////////////////////////////////////////


const editTodo = (id) => {
    document.getElementById('div_edit_todo_mask_' + id).style.display = 'flex';
}

const cancelEditTodo = (id) => {
    document.getElementById('div_edit_todo_mask_' + id).style.display = 'none';
}

const fetchTodoURL = 'https://testapi.io/api/4seven/resource/Todos/';

const confirmEditTodo = (id) => {
    let updatedObject = {};

    updatedObject['UserID'] = user.ID;
    updatedObject['Type'] = document.getElementById('update_type_' + id).value;
    updatedObject['Content'] = document.getElementById('update_content_' + id).value;
    updatedObject['EndDate'] = document.getElementById('update_enddate_' + id).value;
    //updatedObject['Completed'] = user.ID;

    fetch(fetchTodoURL + id, {
        method: 'put',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(updatedObject)
    })
        .then((response) => {
            console.log(response.json());
            p_message.innerHTML = `Todo ${id}, atnaujintas sekmingai!`
            //cancelEditTodo(id);
            getAllTodosForThisUser();
        })
        .catch((error) => {
            console.log(`Request failed with error: ${error}`);
        })
}

///////////////////////////////////////////////////////////////////////////////////////////

const deleteTodo = (id) => {
    document.getElementById('div_delete_todo_mask_' + id).style.display = 'flex';
}

const cancelDeleteTodo = (id) => {
    document.getElementById('div_delete_todo_mask_' + id).style.display = 'none';
}

const fetchTodoOptions = {
    method: 'get',
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    }
}
const deleteTodoOptions = {
    method: 'delete',
    headers: {
        'Accept': 'application/json, text/plain',
        'Content-Type': 'application/json'
    }
}

const confirmDeleteTodo = (id) => {

    fetch(fetchTodoURL + id, fetchTodoOptions)
        .then((response) => response.json())
        .then((todo) => {
            console.log(`Todo rastas: ${todo}`);
            //console.log(todo);
            return fetch(fetchTodoURL + id, deleteTodoOptions)
        })
        .then(res => {
            if (res.ok) {
                p_message.innerHTML += `<br>Todo (id - ${id}) sekmingai istrintas!`;
                getAllTodosForThisUser();
            }
            else {
                p_message.innerHTML += '<br>Klaida! - ' + + res.status;
            }
        })
        .catch((error) => {
            console.log(`Request failed with error: ${error}`);
        })
}

///////////////////////////////////////////////////////////////////////////////////////////