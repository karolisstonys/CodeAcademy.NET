function aboutme() {
    document.getElementById("about").style.display = "block";
    document.getElementById("skills").style.display = "none";
    document.getElementById("github").style.display = "none";
    document.getElementById("contacts").style.display = "none";
    document.getElementById("homework").style.display = "none";
}

function skills() {
    document.getElementById("about").style.display = "none";
    document.getElementById("skills").style.display = "block";
    document.getElementById("github").style.display = "none";
    document.getElementById("contacts").style.display = "none";
    document.getElementById("homework").style.display = "none";
}

function github() {
    document.getElementById("about").style.display = "none";
    document.getElementById("skills").style.display = "none";
    document.getElementById("github").style.display = "block";
    document.getElementById("contacts").style.display = "none";
    document.getElementById("homework").style.display = "none";
}

function contacts() {
    document.getElementById("about").style.display = "none";
    document.getElementById("skills").style.display = "none";
    document.getElementById("github").style.display = "none";
    document.getElementById("contacts").style.display = "flex";
    document.getElementById("homework").style.display = "none";
}

function homework() {
    document.getElementById("about").style.display = "none";
    document.getElementById("skills").style.display = "none";
    document.getElementById("github").style.display = "none";
    document.getElementById("contacts").style.display = "none";
    document.getElementById("homework").style.display = "block";
}







function hw_menu(menu) {
    const hw_1 = document.getElementById('hw_1')
    const hw_2 = document.getElementById('hw_2')
    const hw_3 = document.getElementById('hw_3')

    switch (menu) {
        case 1:
            if (window.getComputedStyle(hw_1).display === 'none')
                hw_1.style.display = 'block';
            if (window.getComputedStyle(hw_2).display === 'block')
                hw_2.style.display = 'none';
            if (window.getComputedStyle(hw_3).display === 'block')
                hw_3.style.display = 'none';
            break;
        case 2:
            if (window.getComputedStyle(hw_1).display === 'block')
                hw_1.style.display = 'none';
            if (window.getComputedStyle(hw_2).display === 'none')
                hw_2.style.display = 'block';
            if (window.getComputedStyle(hw_3).display === 'block')
                hw_3.style.display = 'none';
            hw_2_menu('karsta_kakava'); // REIKIA KAD KitchenToolsSearch VEIKTU
            break;
        case 3:
            if (window.getComputedStyle(hw_1).display === 'block')
                hw_1.style.display = 'none';
            if (window.getComputedStyle(hw_2).display === 'block')
                hw_2.style.display = 'none';
            if (window.getComputedStyle(hw_3).display === 'none')
                hw_3.style.display = 'block';
            break;
    }
}