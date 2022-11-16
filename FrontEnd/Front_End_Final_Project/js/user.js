let messageID = 0;
const clearMessage = (id) => {
    setTimeout(() => {
        document.getElementById('message_' + id).remove();
    }, 5000);
}

const message = (text) => {
    messenger.innerHTML += `<div id="message_${messageID}">${text}</div>`;
    clearMessage(messageID);
    messageID++;
}

///////////////////////////////////////////////////////////////////////////////////////////

const validateForm = () => {
    let isValid = true;
    if (!user_first_name.value) isValid = false;
    if (!user_last_name.value) isValid = false;
    if (!user_email.value) isValid = false;

    if (!isValid) {
        message('Visi laukai yra privalomi, prašome užpildyti tuščius laukus!');
    }

    if (user_email.value && !validateEmail(user_email.value)) {
        isValid = false;
        message('Blogai įvestas el. paštas');
    }
    return isValid;
};

function validateEmail(text) {
    var regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return regex.test(text);
}

const clearForm = () => {
    user_first_name.value = '';
    user_last_name.value = '';
    user_email.value = '';
};

const goToToDo = () => window.location.href = "todo.html";

const saveToLocalStorage = (obj) => localStorage.setItem('USER', JSON.stringify(obj));

///////////////////////////////////////////////////////////////////////////////////////////

document.addEventListener("keypress", (event) => {
    if (event.key === "Enter") {
        event.preventDefault();
        document.getElementById("form_create_user_submit").click();
    }
});

const wannaGoToTodo = () => {
    if (confirm("Naujas vartotojas sukurtas sekmingai! Ar norite prisijungti?") == true) {
        goToToDo();
    } else {
        message('Sveikiname sekmingai sukurus savo vartotoją!');
    }
}

///////////////////////////////////////////////////////////////////////////////////////////

const form_create_user = document.querySelector('#form_create_user');
const postURL = 'https://testapi.io/api/4seven/resource/Users';

const createNewUser = () => {
    let form = new FormData(form_create_user);
    let newObject = {};

    form.forEach((value, key) => { newObject[key] = value });

    fetch(postURL, {
        method: 'post',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(newObject)
    })
        .then(res => {
            //console.log(res);
            //console.log(res.json());
            if (res.ok) {
                clearForm();
                return res.json();
            }
            else message('Klaida: ' + res.status);

        })
        .then(u => {
            const userObj = {
                ID: u.id,
                FirstName: u.FirstName,
                LastName: u.LastName,
                Email: u.Email,
                Created: u.createdAt.slice(0, 10) + ' ' + u.createdAt.slice(11, 19),
                Updated: u.updatedAt.slice(0, 10) + ' ' + u.updatedAt.slice(11, 19)
            }
            saveToLocalStorage(userObj);
            wannaGoToTodo();
        })
        .catch((err) => message('Klaida - ' + err));
}

const form_create_user_submit = document.querySelector('#form_create_user_submit');
form_create_user_submit.addEventListener('click', (e) => {
    e.preventDefault();
    if (validateForm()) createNewUser();
})

///////////////////////////////////////////////////////////////////////////////////////////
