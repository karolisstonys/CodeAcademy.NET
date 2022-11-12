const goToToDo = () => window.location.href = "todo.html";

const form_login = document.querySelector('#form_login');
const login_first_name = document.querySelector('#login_first_name');
const login_last_name = document.querySelector('#login_last_name');

///////////////////////////////////////////////////////////////////////////////////////////

let counter = 0;
const clearMessage = (id) => {
    setTimeout(() => {
        document.getElementById('message_' + id).remove();
    }, 5000);
}

const message = (text) => {
    messenger.innerHTML += `<div id="message_${counter}">${text}</div>`;
    clearMessage(counter);
    counter++;
}
const validateForm = () => {
    if (!login_first_name.value) return false;
    if (!login_last_name.value) return false;
    return true;
};

const clearForm = () => {
    user_first_name.value = '';
    user_last_name.value = '';
    user_email.value = '';
};

const saveToLocalStorage = (obj) => {
    localStorage.setItem('USER', JSON.stringify(obj));
};

///////////////////////////////////////////////////////////////////////////////////////////

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
            //console.log(userData);
            for (const user of userData.data) {
                if (user.FirstName === login_first_name.value &&
                    user.LastName === login_last_name.value) {
                    //message('Vartotojas rastas.');
                    const userObj = {
                        ID: user.id,
                        FirstName: user.FirstName,
                        LastName: user.LastName,
                        Email: user.Email,
                        Created: user.createdAt.slice(0, 10) + ' ' + user.createdAt.slice(11, 19),
                        Updated: user.updatedAt.slice(0, 10) + ' ' + user.updatedAt.slice(11, 19)
                    }
                    //message('USER objektas suformuotas.');
                    saveToLocalStorage(userObj)
                    //message('USER įrasytas į local storage sekmingai.');
                    goToToDo();
                    break;
                }
            }
            message('Vartotojas nerastas!');
        })
        .catch((err) => message('Klaida - ' + err));
}

const login_button = document.querySelector('#login_button');
login_button.addEventListener('click', (e) => {
    e.preventDefault(); // Breaks manual refresh after submit
    if (validateForm())
        lookForUser();
    else {
        message('Visi privalomi laukai turi būti užpildyti!');
    }
})