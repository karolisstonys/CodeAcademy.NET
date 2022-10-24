function changeFirstLi() {
    const ul = document.getElementsByTagName('ul')[0];
    const kavos_li = ul.getElementsByTagName('li')[0];
    kavos_li.innerHTML += ' BLA';
}

function addMilkLi() {
    const ul = document.getElementsByTagName('ul')[0];
    ul.innerHTML += '<li>Milk</li>';
}
