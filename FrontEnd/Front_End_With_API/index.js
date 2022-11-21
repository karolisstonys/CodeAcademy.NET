const getAllData = () => {
    getContainer.innerHTML = '';
    fetch(getAllURL.value, {
        method: 'get',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(obj => obj.json())
        .then(allData => {
            console.log(allData);

            for (const data of allData) {
                getContainer.innerHTML += data.id + ' ─ ' + data.name + ' ─ ' + data.country + ' ─ ' + data.weight + '<br>'
            }
        })
        .catch((err) => {
            getContainer.innerHTML += err + '<br>';
        });
}


const getOneData = () => {
    fetch(getOneURL.value + getOneId.value, {
        method: 'get',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(response => {
            if (response.status === 200)
                response.json()
                    .then(data => {
                        getOneContainer.innerHTML += data.id + ' ─ ' + data.name + ' ─ ' + data.country + ' ─ ' + data.weight;
                    })
            else
                getOneContainer.innerHTML += response.statusText + '<br>';
        })
        .catch((err) => {
            getOneContainer.innerHTML += err + '<br>';
        });
}


const postData = () => {
    let newObject = {
        "id": 0,
        "name": postFoodName.value,
        "country": postFoodCountry.value,
        "weight": postFoodWeight.value
    }

    fetch(postURL.value, {
        method: 'post',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(newObject)
    })
        .then(response => {
            if (response.status === 200)
                response.json()
                    .then(data => {
                        postContainer.innerHTML += data.id + ' ─ ' + data.name + ' ─ ' + data.country + ' ─ ' + data.weight + '<br>';
                        postFoodName.value = '';
                        postFoodCountry.value = '';
                        postFoodWeight.value = '';
                    })
                    .catch((err) => {
                        postContainer.innerHTML += err + '<br>';
                    })
            else
                postContainer.innerHTML += response.statusText + '<br>';
        })
        .catch((err) => {
            postContainer.innerHTML += err + '<br>';
        });

}


const deleteData = () => {
    fetch(getOneURL.value + deleteId.value, {
        method: 'get',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
        .then(obj => {
            if (obj.status === 200) {
                fetch(deleteURL.value + deleteId.value, {
                    method: 'delete'
                })
                    .then(response => {
                        if (response.ok)
                            deleteContainer.innerHTML += 'Food with ID ' + deleteId.value + ' deleted!' + '<br>';
                        else
                            deleteContainer.innerHTML += response.statusText + '<br>';
                    })
                    .catch((err) => {
                        deleteContainer.innerHTML += err + '<br>';
                    });
            }
            else
                deleteContainer.innerHTML += obj.statusText + '<br>';
        })
        .catch((err) => {
            deleteContainer.innerHTML += err + '<br>';
        });



}


const putData = () => {
    let updateObject = {
        "id": 0,
        "name": putFoodName.value,
        "country": putFoodCountry.value,
        "weight": putFoodWeight.value
    }
    fetch(putURL.value + putId.value, {
        method: 'put',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(updateObject)
    })
        .then((response) => {
            if (response.status === 200) {
                putContainer.innerHTML += 'Food with ID ' + putId.value + ' updated!' + '<br>';
                putFoodName.value = '';
                putFoodCountry.value = '';
                putFoodWeight.value = '';
            }
            else
                putContainer.innerHTML += response.statusText + '<br>';
        })
        .catch((err) => {
            putContainer.innerHTML += err + '<br>';
        });

}
