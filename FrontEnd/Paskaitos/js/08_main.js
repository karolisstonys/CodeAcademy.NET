


let a = window.prompt('Skaicius A', '0')
let b = window.prompt('Skaicius B', '0')
let c = window.prompt('Skaicius C', '0')
let kiek = 0;

if (+a < 0) {
    console.log('A yra neigiamas skaicius! ')
    kiek++
}
if (+b < 0) {
    console.log('B yra neigiamas skaicius! ')
    kiek++
}
if (+c < 0) {
    console.log('C yra neigiamas skaicius! ')
    kiek++
}
if (kiek === 0)
    console.log('Neigiamu skaiciu NERA!')
else
    console.log(`Neigiamu skaiciu rasta: ${kiek}`)
