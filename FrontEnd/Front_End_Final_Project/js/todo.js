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
    };
};

const generateGuidQuickly = () => Math.random().toString(36).substring(2, 15) + Math.random().toString(36).substring(2, 15);

///////////////////////////////////////////////////////////////////////////////////////////

const form_new_todo = document.querySelector('#form_new_todo');
const postURL = 'https://testapi.io/api/4seven/resource/Todos';

function createNewTodo() {
    let form = new FormData(form_new_todo);
    let newObject = {};

    form.forEach((value, key) => { newObject[key] = value });
    newObject['UserID'] = user.ID;
    newObject['GUID'] = generateGuidQuickly();

    fetch(postURL, {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(newObject)
    })
        .then(obj => {
            console.log(obj.json())
            p_message.innerHTML += '<br>Naujas todo sukurtas sekmingai!';
            getAllTodosForThisUser(); // TEMP
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
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/json'
    }
}

const saveToLocalStorage = (obj) => {
    localStorage.setItem('ALL_TODOS', JSON.stringify(obj));
}

const showUserTodos = () => {
    const allUserTodos = JSON.parse(localStorage.getItem('ALL_TODOS'));
    for (const todo of allUserTodos) {
        p_message.innerHTML += `<br>${todo.Completed} ${todo.Type} ${todo.Content} ${todo.EndDate} ${todo.GUID}`;

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
                        Completed: todo.Completed,
                        Type: todo.Type,
                        Content: todo.Content,
                        EndDate: todo.EndDate,
                        GUID: todo.GUID
                    });
                }
            }

            saveToLocalStorage(userTodosArr)
            showUserTodos();
        })
        .catch((err) => p_message.innerHTML = err);
}

///////////////////////////////////////////////////////////////////////////////////////////