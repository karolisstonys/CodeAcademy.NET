let isValid_hw_3_CardNumber = false;
let isValid_hw_3_CardHolderName = false;
let isValid_hw_3_CardExp = false;
let isValid_hw_3_CardCVC = false;


function hw_3_validateCardNumber() {
    let hw_3_CardNumber = document.getElementById('hw_3_CardNumber');
    hw_3_CardNumber.style.borderColor = "black";
    if (hw_3_CardNumber.value.length === 16) {
        document.getElementsByClassName('CardNumberDots')[0].innerHTML = hw_3_CardNumber.value;
        isValid_hw_3_CardNumber = true;
    }
    else {
        hw_3_CardNumber.style.borderColor = "red";
        isValid_hw_3_CardNumber = false;
    }
    hm_3_validateForm();
}

function hw_3_CardHolderName() {
    let hw_3_CardHolderName = document.getElementById('hw_3_CardHolderName');
    if (hw_3_CardHolderName.value.length > 0) {
        document.getElementsByClassName('FullName')[0].innerHTML = hw_3_CardHolderName.value;
        isValid_hw_3_CardHolderName = true;
    }
    else
        isValid_hw_3_CardHolderName = false;
    hm_3_validateForm();
}

function hw_3_CardExp() {
    let hw_3_CardExp = document.getElementById('hw_3_CardExp');
    if (hw_3_CardExp.value.length > 0) {
        document.getElementsByClassName('CardDate')[0].innerHTML = hw_3_CardExp.value;
        isValid_hw_3_CardExp = true;
    }
    else
        isValid_hw_3_CardExp = false;
    hm_3_validateForm();
}


function hw_3_CardCVC() {
    let hw_3_CardCVC = document.getElementById('hw_3_CardCVC');
    if (hw_3_CardCVC.value.length === 3) {
        isValid_hw_3_CardCVC = true;
    }
    else
        isValid_hw_3_CardCVC = false;
    hm_3_validateForm();
}

function hm_3_validateForm() {
    let submit = document.getElementById('hw_3_Submit');
    if (isValid_hw_3_CardNumber &&
        isValid_hw_3_CardHolderName &&
        isValid_hw_3_CardExp &&
        isValid_hw_3_CardCVC)
        submit.removeAttribute("disabled");
    else
        submit.setAttribute('disabled', 'disabled');
}



