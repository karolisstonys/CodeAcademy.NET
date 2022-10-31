const showValues = () => {
    lbl_mokymai_key.innerHTML = sessionStorage.mokymai_key ?? '-';
    lbl_kitas_raktas.innerHTML = sessionStorage.kitas_raktas ?? '-';
    lbl_mokymai_localStorage.innerHTML = localStorage.mokymai_localStorage ?? '-';
    lbl_json_localStorage.innerHTML = localStorage.json_localStorage ?? '-';
};
document.addEventListener('DOMContentLoaded', showValues);


// ********************* SET *********************

btn_setSessionStorage.addEventListener('click', () => {
    sessionStorage.setItem('mokymai_key', 'kazkokia nesudetinga reiksme');
    txt_setSessionStorage.innerHTML = 'irasyta i session storage sekmingai';
    txt_setSessionStorage.style.color = 'green';
})

btn_setSessionStorage1.addEventListener('click', () => {
    sessionStorage.setItem('kitas_raktas', 'kazkokia kito rakto reiksme');
    txt_setSessionStorage1.innerHTML = 'irasyta i session storage sekmingai';
    txt_setSessionStorage1.style.color = 'green';
})

btn_setLocalStorage.addEventListener('click', () => {
    const asmuo = {
        vardas: 'Vardenis',
        pavarde: 'Pavardenis'
    }
    localStorage.setItem('mokymai_localStorage', asmuo);
    txt_setLocalStorage.innerHTML = 'irasyta i local storage sekmingai';
    txt_setLocalStorage.style.color = 'blue';
})

btn_json_setLocalStorage.addEventListener('click', () => {
    const asmuo = {
        vardas: 'Vardenis',
        pavarde: 'Pavardenis'
    }
    localStorage.setItem('json_localStorage', JSON.stringify(asmuo));
    txt_json_setLocalStorage.innerHTML = 'irasyta i local storage sekmingai';
    txt_json_setLocalStorage.style.color = 'blue';
})

// ********************* GET *********************

btn_getMokymaiKey.addEventListener('click', () => {
    const val = sessionStorage.getItem('mokymai_key');
    txt_getMokymaiKey.innerHTML = val ?? 'nieko nera';
})

btn_get_kitas_raktas.addEventListener('click', () => {
    const val = sessionStorage.getItem('kitas_raktas');
    txt_get_kitas_raktas.innerHTML = val ?? 'nieko nera';
})

btn_get_mokymai_localStorage.addEventListener('click', () => {
    const val = localStorage.mokymai_localStorage;  // Object-like access
    txt_get_mokymai_localStorage.innerHTML = val ?? 'nieko nera';
})

btn_getLocalStorage.onclick = () => {               // .onclick atributas
    const val = localStorage.json_localStorage;     // Object-like access
    txt_getLocalStorage.innerHTML = val ?? 'nieko nera';
};

// ********************* REMOVE *********************

btn_remove_mokymai_key.addEventListener('click', () => {
    sessionStorage.removeItem('mokymai_key');
    showValues();
})

btn_remove_kitas_raktas.addEventListener('click', () => {
    sessionStorage.removeItem('kitas_raktas');
    showValues();
})

btn_get_mokymai_localStorage.addEventListener('click', () => {
    localStorage.removeItem('mokymi_localStorage');
    showValues();
})

btn_remove_json_localStorage.onclick = () => {
    localStorage.removeItem('json_localStorage');
    showValues();
};

// ********************* CLEAR *********************

btn_clear_session_storage.addEventListener('click', () => {
    sessionStorage.clear();
    showValues();
})

btn_clear_session_storage.onclick = () => {
    localStorage.clear();
    showValues();
};







