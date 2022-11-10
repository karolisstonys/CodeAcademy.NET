const goToCreateUser = () => {
    window.location.href = "index.html";
}

p_login.addEventListener('click', goToCreateUser);

const message = p_message;
const form_create_user = document.querySelector('#form_create_user');

function createNewUser() {
    let form = new FormData(form_create_user);
    let newObject = {};

    console.log(form);

    form.forEach((value, key) => { newObject[key] = value });

    fetch('https://testapi.io/api/4seven/resource/Users', {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(newObject)
    })
        .then(obj => {
            console.log(obj.json())
            message.innerHTML = 'Naujas vartotojas sukurtas sekmingai!';
        })
        .catch((err) => message.innerHTML = 'Vartotoją sukurti nepavyko - ' + err);
}

const form_create_user_submit = document.querySelector('#form_create_user_submit');
form_create_user_submit.addEventListener('click', (e) => {
    e.preventDefault(); // Breaks manual refresh after submit
    createNewUser();
})









