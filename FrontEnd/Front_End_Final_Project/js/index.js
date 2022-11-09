const goToCreateUser = () => {
    window.location.href = "create_user.html";
}

p_create_user.addEventListener('click', goToCreateUser);

const message = p_message;
const form_login = document.querySelector('#form_login');
const login_first_name = document.querySelector('#login_first_name');
const login_last_name = document.querySelector('#login_last_name');

function lookForUser() {
    fetch('https://testapi.io/api/4seven/resource/Users', {
        method: 'get',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        }
    })
        .then(obj => obj.json())
        .then(userData => {
            console.log(userData);
            for (const user of userData.data) {
                if (user.FirstName === login_first_name.value &&
                    user.LastName === login_last_name.value) {
                    message.innerHTML = 'Vartotojas rastas ' + user.Email;
                }
            }
        })
        .catch((err) => message.innerHTML = err);
}

const login_button = document.querySelector('#login_button');
login_button.addEventListener('click', (e) => {
    e.preventDefault(); // Breaks manual refresh after submit
    lookForUser();
})






