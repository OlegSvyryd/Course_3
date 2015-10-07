/**
 * Class Calculate - lab 4 EMP
 * @param n Variant
 * @constructor Constructor of class Calculate
 */
function Calculate(n) {
    this.N = n;
    this.AMOUNT_ITEMS = 2 * this.N + 5;
    this.AMOUNT_ITEMS_NORMAL = 100 * (2 * this.N + 5);
    this.array = [];
    this.array.length = this.AMOUNT_ITEMS;
    this.arrayNormal = [];
    this.arrayNormal.length = this.AMOUNT_ITEMS_NORMAL;
};

/**
 * Initialize array random numbers
 */
Calculate.prototype.initializeArray = function() {
    for(i = 0; i < this.array.length; i++) {
        this.array[i] = Math.random();
    }
    return this.array;
};

/**
 * Initialize array random numbers normal
 */
Calculate.prototype.initializeArrayNormal = function() {
    for(i = 0; i < this.arrayNormal.length; i++) {
        this.arrayNormal[i] = ((Math.random() + Math.random() + Math.random() + Math.random() + Math.random() + Math.random()) - 3) / 3;
    }
    return this.arrayNormal;
};

/**
 * Calculate average
 * @returns {number} Average
 */
Calculate.prototype.getAvg = function(arr) {
    var sum = 0;
    for(i = 0; i < arr.length; i++) {
        sum += parseFloat(arr[i]);
    }
    return sum / arr.length;
};

/**
 * Calculate mean square
 * @returns {number} Mean Square
 */
Calculate.prototype.getMeanSquare = function (arr) {
    return Math.sqrt(this.getAvg(arr));
};

/**
 * Calculate asymmetry
 * @returns {number} Asymmetry
 */
Calculate.prototype.getAsymmetry = function (arr) {
    console.log(arr.length);
    var centralMomentThree = 0;
    for(i = 0; i < arr.length; i++) {
        centralMomentThree += parseFloat(Math.pow((arr[i] - this.getAvg(arr)), 3));
    }
    centralMomentThree /= arr.length;
    return centralMomentThree / Math.pow(this.getMeanSquare(arr), 3);
};

/**
 * Calculate excess
 * @returns {number} Excess
 */
Calculate.prototype.getExcess = function (arr) {
    var centralMomentFour = 0;
    for(i = 0; i < arr.length; i++) {
        centralMomentFour += parseFloat(Math.pow((arr[i] - this.getAvg(arr)), 4));
    }
    centralMomentFour /= arr.length;
    return (centralMomentFour / Math.pow(this.getMeanSquare(arr), 2)) - 3
};

Calculate.prototype.draw = function (f, cnt, color) {
    var numbers = [];
    for (var i = 0; i < 200; i++) numbers[i] = 0;
    for (var i = 0; i < cnt; i++) {
        numbers[100 + Math.round(100 * f())]++;
    }
    for (var i = 0; i < 200; i++) {
        $('#container').append($('<div>').css({
            left: i * 2 + 'px',
            height: numbers[i] / 25 + 'px',
            background: color
        }));
    }
};