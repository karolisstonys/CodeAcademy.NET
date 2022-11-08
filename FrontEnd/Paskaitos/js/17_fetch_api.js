//const url = 'https://swapi.dev/api/starships';
//const options = {};

/*const getSwapiStarship = (obj) => {
    fetch(url, options)
        .then(response => response.json())
        .then(data => {
            starships_name.innerHTML = data.results[obj].name;
            starships_model.innerHTML = "model: " + data.results[obj].model;
            starships_manufacturer.innerHTML = "manufacturer: " + data.results[obj].manufacturer;
            starships_cost_in_credits.innerHTML = "cost in credits: " + data.results[obj].cost_in_credits;
            starships_length.innerHTML = "length: " + data.results[obj].length;
            starships_max_atmosphering_speed.innerHTML = "max atmosphering speed: " + data.results[obj].max_atmosphering_speed;
            starships_crew.innerHTML = "crew: " + data.results[obj].crew;
            starships_passengers.innerHTML = "passengers: " + data.results[obj].passengers;
            starships_cargo_capacity.innerHTML = "cargo capacity: " + data.results[obj].cargo_capacity;
            starships_consumables.innerHTML = "consumables: " + data.results[obj].consumables;
        });
}*/

// ------------------------------------------------------------------------------------------------------------

const loadDataSimple = () => {
    fetch(url)
        .then(res => {
            if (res.ok) {
                console.log(res);
                return res.json();
            } else {
                console.log("Got error. Status : " + res.status)
            }
        })
}

const loadDataAsync = async () => {
    try {
        const response = await fetch(url);
        const data = await response.json();
        console.log(data.results);
    } catch (error) {
        console.error(error);
    }
}
//loadDataAsync();

// ------------------------------------------------------------------------------------------------------------

const urlStarships = 'https://swapi.dev/api/starships';
const getSwapiStarship = async (obj) => {
    const response = await fetch(urlStarships);
    const data = await response.json();
    starships_name.innerHTML = data.results[obj].name;
    starships_model.innerHTML = "model: " + data.results[obj].model;
    starships_manufacturer.innerHTML = "manufacturer: " + data.results[obj].manufacturer;
    starships_cost_in_credits.innerHTML = "cost in credits: " + data.results[obj].cost_in_credits;
    starships_length.innerHTML = "length: " + data.results[obj].length;
    starships_max_atmosphering_speed.innerHTML = "max atmosphering speed: " + data.results[obj].max_atmosphering_speed;
    starships_crew.innerHTML = "crew: " + data.results[obj].crew;
    starships_passengers.innerHTML = "passengers: " + data.results[obj].passengers;
    starships_cargo_capacity.innerHTML = "cargo capacity: " + data.results[obj].cargo_capacity;
    starships_consumables.innerHTML = "consumables: " + data.results[obj].consumables;
    console.log(data);
}

const urlPlanets = 'https://swapi.dev/api/planets';

const getSwapiAllPlanetsCount = async () => {

}


const getSwapiAllPlanets = async () => {
    const response = await fetch(urlPlanets);
    const data = await response.json();
    table_swapi_planets.innerHTML = '<tr><th>Name</th><th>Diameter</th><th>Climate</th><th>Gravity</th><th>Terrain</th><th>Population</th><th>Residents</th><th>Films</th></tr>';

    for (let i = 0; i < data.results.length; i++) {
        // fake fetch await just to show delay
        const response2 = await fetch(urlPlanets);
        const data2 = await response2.json();
        table_swapi_planets.innerHTML += `<tr><td>${data2.results[i].name}</td><td>${data2.results[i].diameter}</td><td>${data2.results[i].climate}</td><td>${data2.results[i].gravity}</td><td>${data2.results[i].terrain}</td><td>${data2.results[i].population}</td><td>${data2.results[i].residents.length}</td><td>${data2.results[i].films.length}</td></td>`;
    }
}



