const goToCreateUser = () => window.location.href = "user.html";
const goToToDo = () => window.location.href = "todo.html";

p_create_user.addEventListener('click', goToCreateUser);

///////////////////////////////////////////////////////////////////////////////////////////

const form_login = document.querySelector('#form_login');
const login_first_name = document.querySelector('#login_first_name');
const login_last_name = document.querySelector('#login_last_name');

const validateForm = () => {
    if (!login_first_name.value) return false;
    if (!login_last_name.value) return false;
    return true;
};

const saveToLocalStorage = (obj) => {
    localStorage.setItem('USER', JSON.stringify(obj));
};

const getURL = 'https://testapi.io/api/4seven/resource/Users';
const getOptions = {
    method: 'get',
    headers: {
        'Accept': 'application/json, text/plain',
        'Content-Type': 'application/json'
    }
}

const lookForUser = () => {
    fetch(getURL, getOptions)
        .then(obj => obj.json())
        .then(userData => {
            console.log(userData);
            for (const user of userData.data) {
                if (user.FirstName === login_first_name.value &&
                    user.LastName === login_last_name.value) {
                    //p_message.innerHTML += '<br>Vartotojas rastas.';
                    const userObj = {
                        ID: user.id,
                        FirstName: user.FirstName,
                        LastName: user.LastName,
                        Email: user.Email,
                        Created: user.createdAt.slice(0, 10) + ' ' + user.createdAt.slice(11, 19),
                        Updated: user.updatedAt.slice(0, 10) + ' ' + user.updatedAt.slice(11, 19)
                    }
                    //p_message.innerHTML += '<br>USER objektas suformuotas.';
                    saveToLocalStorage(userObj)
                    //p_message.innerHTML += '<br>USER įrasytas į local storage sekmingai.';
                    goToToDo();
                    break;
                }
            }
            p_message.innerHTML += '<br>Vartotojas nerastas';
        })
        .catch((err) => p_message.innerHTML = err);
}

const login_button = document.querySelector('#login_button');
login_button.addEventListener('click', (e) => {
    e.preventDefault(); // Breaks manual refresh after submit
    if (validateForm())
        lookForUser();
    else {
        p_message.innerHTML += '<br>Forma nėra validi!';
    }
})