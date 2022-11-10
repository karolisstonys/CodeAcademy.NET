const goToLogin = () => window.location.href = "login.html";

p_login.addEventListener('click', goToLogin);

///////////////////////////////////////////////////////////////////////////////////////////

const form_create_user = document.querySelector('#form_create_user');
const postURL = 'https://testapi.io/api/4seven/resource/Users';

function createNewUser() {
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
            console.log(obj.json())
            p_message.innerHTML += '<br>Naujas vartotojas sukurtas sekmingai!';
        })
        .catch((err) => p_message.innerHTML += '<br>Vartotoją sukurti nepavyko - ' + err);
}

const form_create_user_submit = document.querySelector('#form_create_user_submit');
form_create_user_submit.addEventListener('click', (e) => {
    e.preventDefault(); // Breaks manual refresh after submit
    createNewUser();
})









