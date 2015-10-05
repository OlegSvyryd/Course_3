/**
 * Class Calculate - lab 4 EMP
 * @param n Variant
 * @constructor Constructor of class Calculate
 */
function Calculate(n) {
    this.N = n;
    this.AMOUNT_ITEMS = 100 * this.N;
    this.array = [];
    this.array.length = this.AMOUNT_ITEMS;
};

/**
 * Generate random float numbers in range
 * @param min Min range
 * @param max Max range
 * @return Random value in range above
 */
Calculate.prototype.randomInRange = function(min, max) {
    var range = max - min;
    var scaled = Math.random() * range;
    var shifted = scaled + min;
    return shifted;
};

/**
 * Initialize array random numbers
 */
Calculate.prototype.initializeArray = function() {
    for(i = 0; i < this.array.length; i++) {
        this.array[i] = calc.randomInRange(0, this.N).toFixed(2);
        //console.log(this.array[i]); //display array items
    }
    return this.array;
};

/**
 * Calculate average
 * @returns {number} Average
 */
Calculate.prototype.getAvg = function() {
    var sum = 0;
    for(i = 0; i < this.array.length; i++) {
        sum += parseFloat(this.array[i]);
    }
    return sum / this.array.length;
};

/**
 * Calculate variance
 * @returns {number} Variance
 */
Calculate.prototype.getVariance = function() {
    var sum = 0;
    for(i = 0; i < this.array.length; i++) {
        sum += parseFloat(Math.pow((this.array[i] - this.getAvg()), 2));
    }
    return sum / this.array.length;
};

/**
 * Calculate mean square
 * @returns {number} Mean Square
 */
Calculate.prototype.getMeanSquare = function () {
    return Math.sqrt(this.getAvg());
};

/**
 * Calculate asymmetry
 * @returns {number} Asymmetry
 */
Calculate.prototype.getAsymmetry = function () {
    var centralMomentThree = 0;
    for(i = 0; i < this.array.length; i++) {
        centralMomentThree += parseFloat(Math.pow((this.array[i] - this.getAvg()), 3));
    }
    centralMomentThree /= this.array.length;
    return centralMomentThree / Math.pow(this.getMeanSquare(), 3);
};

/**
 * Calculate excess
 * @returns {number} Excess
 */
Calculate.prototype.getExcess = function () {
    var centralMomentFour = 0;
    for(i = 0; i < this.array.length; i++) {
        centralMomentFour += parseFloat(Math.pow((this.array[i] - this.getAvg()), 4));
    }
    centralMomentFour /= this.array.length;
    return (centralMomentFour / Math.pow(this.getMeanSquare(), 2)) - 3
};