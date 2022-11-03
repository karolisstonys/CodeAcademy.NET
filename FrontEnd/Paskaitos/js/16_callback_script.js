
const repeat = (str, times) => {
    let res = "";
    for (let i = 0; i < times; i++) {
        res += str;
    }
    return res;
}

const scream = (str) => {
    return str.toUpperCase() + '!!!';
}

const runFlow = (phrase) => {
    let text = scream(phrase);
    let rant = repeat(text, 10);
    return rant;
}

const runRant = (phrase, el) => {
    const h1 = document.createElement('h1');
    h1.innerText = runFlow(phrase);
    el.appendChild(h1);
}

console.log("Hello world!");

runRant("labas rytas", document.body);


// PART 2

const divBox = document.querySelector('div.box');

const moveX = (ele, movePx, delay, onSuccess, onFailure) => {
    setTimeout(() => {
        const bodyBoundary = document.body.clientWidth;
        const elRight = ele.getBoundingClientRect().right;
        const elleft = ele.getBoundingClientRect().left;


        if (elRight + movePx > bodyBoundary) {
            onFailure()
        } else {
            ele.style.transform = `translateX(${elleft + movePx}px)`;
            onSuccess();
        }

    }, delay)
}

moveX(divBox, 300, 1000, () => { }, () => { });









