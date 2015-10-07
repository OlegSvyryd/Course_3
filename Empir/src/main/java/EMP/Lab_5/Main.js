var calc = new Calculate(18);

console.log(calc.initializeArray());
console.log(calc.initializeArrayNormal());
console.log('Assymetry: ' + calc.getAsymmetry(calc.array));
console.log('Excess: ' + calc.getExcess(calc.array));
console.log('Assymetry for normal numbers: ' + calc.getAsymmetry(calc.arrayNormal));
console.log('Excess for normal numbers: ' + calc.getExcess(calc.arrayNormal));

/**
 * Function for show graphic of random value
 * @returns {number} Random value
 */
function rnd() {
    return Math.random() - Math.random();
}
/**
 * Function for show graphic of random normal value
 * @returns {number} Random normal value
 */
function rnd2() {
    return ((Math.random() + Math.random() + Math.random() + Math.random() + Math.random() + Math.random()) - 3) / 3;
}

calc.draw(rnd, 700000, 'rgba(128,0,0,.4)');
calc.draw(rnd2, 600000, 'rgba(0,128,0,.6)');