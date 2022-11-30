const form_login = document.querySelector('#form_login');

document.addEventListener("keypress", (event) => {
    if (event.key === "Enter") {
        event.preventDefault();
        document.getElementById("login_button").click();
    }
});

///////////////////////////////////////////////////////////////////////////////////////////

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
    if (!login_username.value) return false;
    if (!login_password.value) return false;
    return true;
};

const goToWishlist = () => window.location.href = "wishlist.html";

const saveToLocalStorage = (obj) => localStorage.setItem('USER', JSON.stringify(obj));

///////////////////////////////////////////////////////////////////////////////////////////

const getOptions = {
    method: 'get',
    headers: {
        'Accept': 'application/json'
    }
}

const login = () => {
    fetch(login_get_address.value + "?username=" + login_username.value + "&password=" + login_password.value, {
        method: 'get',
        headers: {
            'Accept': 'application/json'
        }
    })
        .then(obj => {
            if (obj.ok) {
                obj.json()
                    .then(userData => {
                        const userObj = {
                            id: userData.id,
                            username: userData.username,
                            guid: userData.guid,
                            role: userData.role
                        }
                        saveToLocalStorage(userObj)
                        //goToWishlist();
                    })
            }
            else {
                console.log('Klaida - ' + obj.statusText);
            }
        })
        .catch((err) => message('Klaida - ' + err));
}

const login_button = document.querySelector('#login_button');
login_button.addEventListener('click', (e) => {
    e.preventDefault();
    if (validateForm())
        login();
    else {
        message('Visi privalomi laukai turi būti užpildyti!');
    }
})

///////////////////////////////////////////////////////////////////////////////////////////