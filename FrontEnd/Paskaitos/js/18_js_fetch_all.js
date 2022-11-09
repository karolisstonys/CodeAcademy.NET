const animalFormPost = document.querySelector('#animal_form_post');
const animalFormSubmitButton = document.querySelector('#animal_form_submit');

function sendData() {
    let data = new FormData(animalFormPost);
    let obj = {};

    data.forEach((value, key) => obj[key] = value);

    console.log(data);
    console.log(obj);

    fetch('https://testapi.io/api/4seven/resource/Animals', {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain, */*', // */* - leidzia bet ka !!
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(obj)
    })
        .then((res) => { console.log(res.json()) })
        .catch((err) => { console.log(err) })
}

animalFormSubmitButton.addEventListener('click', (e) => {
    e.preventDefault(); // breaks refresh after submit
    sendData();
});


//////////////////////////////////////////////////////////////////////////////////////////////


const get_animal_by_id = document.querySelector('#get_animal_by_id');
get_animal_button.addEventListener('click', (e) => {
    e.preventDefault(); // breaks refresh after submit
    getData();
});

const getURL = 'https://testapi.io/api/4seven/resource/Animals/' + get_animal_by_id.value;
const getOptions = {
    method: 'get',
    headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
    }
};

const getData = () => {
    fetch(getURL, getOptions)
        .then(res => res.json())
        .then(animalData => {
            get_animal_id.innerHTML = animalData.id;
            get_animal_name.innerHTML = animalData.Name;
            get_animal_type.innerHTML = animalData.Type;
            get_animal_legs.innerHTML = animalData.Legs;
            get_animal_created.innerHTML = animalData.createdAt.slice(0, 19);
            get_animal_modified.innerHTML = animalData.updatedAt.slice(0, 19);;
        })
}


//////////////////////////////////////////////////////////////////////////////////////////////

const animal_form_update = document.querySelector('#animal_form_update');
const update_animal_by_id = document.querySelector('#update_animal_by_id');
const update_animal_button = document.querySelector('#update_animal_button');

function sendData() {
    let data = new FormData(animal_form_update);
    let obj = {};

    data.forEach((value, key) => {
        obj[key] = value
    });

    const url = 'https://testapi.io/api/4seven/resource/Animals/' + update_animal_by_id.value;

    fetch(url, {
        method: 'put',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(obj)
    })
        .then(obj => {
            const res = obj.json();
            update_message.innerHTML = 'Updated!';
            return res;
        })
        .catch((klaida) => update_message.innerHTML = klaida);
}

update_animal_button.addEventListener('click', (e) => {
    e.preventDefault(); // Breaks manual refresh after submit
    sendData();
})
