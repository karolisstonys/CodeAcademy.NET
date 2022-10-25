



function hw_2_menu(menu) {

    const hw_2_menu_karsta_kakava = document.getElementById('hw_2_menu').getElementsByTagName('li')[0];
    const hw_2_menu_tinginys_su_pienu = document.getElementById('hw_2_menu').getElementsByTagName('li')[1];
    const hw_2_menu_brownie_be_nieko = document.getElementById('hw_2_menu').getElementsByTagName('li')[2];

    hw_2_menu_karsta_kakava.classList.remove('selected');
    hw_2_menu_tinginys_su_pienu.classList.remove('selected');
    hw_2_menu_brownie_be_nieko.classList.remove('selected');

    const visos_kakavos = document.getElementsByClassName('karsta_kakava')
    const visi_tinginiai = document.getElementsByClassName('tinginys_su_pienu')
    const visi_brownie = document.getElementsByClassName('brownie_be_nieko')

    switch (menu) {
        case 'karsta_kakava':
            findAndShowKitchenTools('karsta_kakava');

            hw_2_menu_karsta_kakava.classList.add('selected');

            for (const kakava of visos_kakavos) {
                if (window.getComputedStyle(kakava).display === 'none')
                    kakava.style.display = 'block';
            }
            for (const tinginys of visi_tinginiai) {
                if (window.getComputedStyle(tinginys).display === 'block')
                    tinginys.style.display = 'none';
            }
            for (const brownie of visi_brownie) {
                if (window.getComputedStyle(brownie).display === 'block')
                    brownie.style.display = 'none';
            }
            break;
        case 'tinginys_su_pienu':
            findAndShowKitchenTools('tinginys_su_pienu');

            hw_2_menu_tinginys_su_pienu.classList.add('selected');

            for (const kakava of visos_kakavos) {
                if (window.getComputedStyle(kakava).display === 'block')
                    kakava.style.display = 'none';
            }
            for (const tinginys of visi_tinginiai) {
                if (window.getComputedStyle(tinginys).display === 'none')
                    tinginys.style.display = 'block';
            }
            for (const brownie of visi_brownie) {
                if (window.getComputedStyle(brownie).display === 'block')
                    brownie.style.display = 'none';
            }
            break;
        case 'brownie_be_nieko':
            findAndShowKitchenTools('brownie_be_nieko');

            hw_2_menu_brownie_be_nieko.classList.add('selected');

            for (const kakava of visos_kakavos) {
                if (window.getComputedStyle(kakava).display === 'block')
                    kakava.style.display = 'none';
            }
            for (const tinginys of visi_tinginiai) {
                if (window.getComputedStyle(tinginys).display === 'block')
                    tinginys.style.display = 'none';
            }
            for (const brownie of visi_brownie) {
                if (window.getComputedStyle(brownie).display === 'none')
                    brownie.style.display = 'block';
            }
            break;
    }
}

function findAndShowKitchenTools(recipe) {

    let bowl = document.getElementById('bowl');
    bowl.style.display = 'none';

    let cup = document.getElementById('cup');
    cup.style.display = 'none';

    let spoon = document.getElementById('spoon');
    spoon.style.display = 'none';

    let forkAndKnife = document.getElementById('forkAndKnife');
    forkAndKnife.style.display = 'none';

    switch (recipe) {
        case 'karsta_kakava':
            const visos_kakavos_steps = document.getElementsByClassName('Steps')[0]
                .getElementsByClassName('karsta_kakava')[1].children;

            for (const step of visos_kakavos_steps) {
                if (step.innerHTML.includes('duben')) bowl.style.display = 'inline-block';
                if (step.innerHTML.includes('puodel')) cup.style.display = 'inline-block';
                if (step.innerHTML.includes('šaukšt')) spoon.style.display = 'inline-block';
                if (step.innerHTML.includes('pjaust')) forkAndKnife.style.display = 'inline-block';
            }

            break;

        case 'tinginys_su_pienu':
            const visi_tinginio_steps = document.getElementsByClassName('Steps')[0]
                .getElementsByClassName('tinginys_su_pienu')[1].children;

            for (const step of visi_tinginio_steps) {
                if (step.innerHTML.includes('duben')) bowl.style.display = 'inline-block';
                if (step.innerHTML.includes('puodel')) cup.style.display = 'inline-block';
                if (step.innerHTML.includes('šaukšt')) spoon.style.display = 'inline-block';
                if (step.innerHTML.includes('pjaust')) forkAndKnife.style.display = 'inline-block';
            }
            break;

        case 'brownie_be_nieko':
            const visi_brownie_steps = document.getElementsByClassName('Steps')[0]
                .getElementsByClassName('brownie_be_nieko')[1].children;

            for (const step of visi_brownie_steps) {
                if (step.innerHTML.includes('duben')) bowl.style.display = 'inline-block';
                if (step.innerHTML.includes('puodel')) cup.style.display = 'inline-block';
                if (step.innerHTML.includes('šaukšt')) spoon.style.display = 'inline-block';
                if (step.innerHTML.includes('pjaust')) forkAndKnife.style.display = 'inline-block';

            }

            break;
    }
}