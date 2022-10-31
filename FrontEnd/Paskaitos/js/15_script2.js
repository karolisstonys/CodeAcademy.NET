



const saveFormData = (key, value) => {
    const json = sessionStorage.getItem('formData');
    const obj = JSON.parse(json);
    const o = Object.assign({}, obj);
    o[key] = value;
    sessionStorage.setItem('formData', JSON.stringify(o))
}
txt1.addEventListener('change', (e) => {
    saveFormData('txt1', e.target.value)
})
txt2.addEventListener('change', (e) => {
    saveFormData('txt2', e.target.value)
})
txt3.addEventListener('change', (e) => {
    saveFormData('txt3', e.target.value)
})

document.addEventListener('DOMContentLoaded', () => {
    const o = Object.assign({}, JSON.parse(sessionStorage.getItem('formData')));
    txt1.value = o.txt1 ?? '-';
    txt2.value = o.txt2 ?? '-';
    txt3.value = o.txt3 ?? '-';
})
