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
    let rtn = true;
    if (!user_first_name.value) { rtn = false; }
    if (!user_last_name.value) { rtn = false; }
    if (!user_email.value) { rtn = false; }
    return rtn;
};

const clearForm = () => {
    user_first_name.value = '';
    user_last_name.value = '';
    user_email.value = '';
};

///////////////////////////////////////////////////////////////////////////////////////////

document.addEventListener("keypress", (event) => {
    if (event.key === "Enter") {
        event.preventDefault();
        document.getElementById("form_create_user_submit").click();
    }
});

///////////////////////////////////////////////////////////////////////////////////////////

const form_create_user = document.querySelector('#form_create_user');
const postURL = 'https://testapi.io/api/4seven/resource/Users';

const createNewUser = () => {
    let form = new FormData(form_create_user);
    let newObject = {};

    console.log(form);

    form.forEach((value, key) => { newObject[key] = value });

    fetch(postURL, {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(newObject)
    })
        .then(obj => {
            console.log(obj.json());
            clearForm();
            message('Naujas vartotojas sukurtas sekmingai!');
        })
        .catch((err) => message('Klaida - ' + err));
}

const form_create_user_submit = document.querySelector('#form_create_user_submit');
form_create_user_submit.addEventListener('click', (e) => {
    e.preventDefault(); // Breaks manual refresh after submit
    if (validateForm())
        createNewUser();
    else {
        message('Visi privalomi laukai turi būti užpildyti!');
    }
})









