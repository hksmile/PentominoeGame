
        function detectWebGLContext() {
            // Create canvas element. The canvas is not added to the
            // document itself, so it is never displayed in the
            // browser window.
            var canvas = document.createElement("canvas");
            // Get WebGLRenderingContext from canvas element.
            var gl = canvas.getContext("webgl")
                || canvas.getContext("experimental-webgl");
            // Report the result.
            if (gl && gl instanceof WebGLRenderingContext) {
                alert("Congratulations! Your browser supports WebGL.");
            } else {
                alert("Failed to get WebGL context. "
                    + "Your browser or device may not support WebGL.");
            }
}

function drawGreenSquare() {
    // References to the document elements.
    var canvas = document.getElementsByTagName("canvas")[0];

    // Getting the WebGL rendering context.
    var gl = canvas.getContext("webgl")
        || canvas.getContext("experimental-webgl");

    // If failed, inform user of failure. Otherwise, initialize
    // the drawing buffer (the viewport) and clear the context
    // with a solid color.
    if (!gl) {
        alert("Failed to get WebGL context. "
            + "Your browser or device may not support WebGL.");
        return;
    }
   
    gl.viewport(0, 0,
        gl.drawingBufferWidth, gl.drawingBufferHeight);
    // Set the clear color to darkish green.
    gl.clearColor(0.0, 0.5, 0.0, 1.0);
    // Clear the context with the newly set color. This is
    // the function call that actually does the drawing.
    gl.clear(gl.COLOR_BUFFER_BIT);

}

function drawYellowRectangle() {
    // References to the document elements.
    var canvas = document.getElementsByTagName("canvas")[1];

    // Getting the WebGL rendering context.
    var gl = canvas.getContext("webgl")
        || canvas.getContext("experimental-webgl");

    // The following two lines set the size (in CSS pixels) of
    // the drawing buffer to be identical to the size of the
    // canvas HTML element, as determined by CSS.
    canvas.width = canvas.clientWidth;
    canvas.height = canvas.clientHeight;

    // If failed, inform user of failure. Otherwise, initialize
    // the drawing buffer (the viewport) and clear the context
    // with a solid color.
    if (!gl) {
        alert("Failed to get WebGL context. "
            + "Your browser or device may not support WebGL.");
        return;
    }

    gl.viewport(0, 0,
        gl.drawingBufferWidth, gl.drawingBufferHeight);

    // Enable scissoring operation and define the position and
    // size of the scissoring area.
    gl.enable(gl.SCISSOR_TEST);
    gl.scissor(0, 20, 60, 130);

    // Clear the drawing buffer solid yellow.
    gl.clearColor(1.0, 1.0, 0.0, 1.0);
    gl.clear(gl.COLOR_BUFFER_BIT);

}

function drawPentominoeL()
{
    // References to the document elements.
    var canvas = document.getElementsByTagName("canvas")[2];

    // Getting the WebGL rendering context.
    var gl = canvas.getContext("webgl")
        || canvas.getContext("experimental-webgl");

    // The following two lines set the size (in CSS pixels) of
    // the drawing buffer to be identical to the size of the
    // canvas HTML element, as determined by CSS.
    canvas.width = canvas.clientWidth;
    canvas.height = canvas.clientHeight;

    // If failed, inform user of failure. Otherwise, initialize
    // the drawing buffer (the viewport) and clear the context
    // with a solid color.
    if (!gl) {
        alert("Failed to get WebGL context. "
            + "Your browser or device may not support WebGL.");
        return;
    }

    gl.viewport(0, 0,
        gl.drawingBufferWidth, gl.drawingBufferHeight);

    // Enable scissoring operation and define the position and
    // size of the scissoring area.
    gl.enable(gl.SCISSOR_TEST);
    gl.scissor(0, 20, 60, 130);

    // Clear the drawing buffer solid yellow.
    gl.clearColor(1.0, 1.0, 0.0, 1.0);
    gl.clear(gl.COLOR_BUFFER_BIT);

}

function getRandomIntInclusive(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

var two;
  var colors = ["red", "blue", "green", "magenta", "brown"];
var window_width = 20;
var colorDictionary = {"I": "blue", "F":"green", "Y":"yellow", "V":"red", "T":"brown", "X":"darkblue", "Z":"gray", "U":"lime", "N":"cyan", "P":"pink", "L":"orange", "W":"purple"};

function initalizeTwo() {
    var elem = document.getElementById('myCanvas');
    two = new Two({
        type: Two.Types.svg,
        fullscreen: false
    }).appendTo(elem);
}



function drawGameBoardTest(squareLength) {
    if (!two) initalizeTwo();

    var b = [
        ["green", "white", "red"],
        ["white", "green", "red"]
    ];


    width = 3;
    height = 2;

    var xIndex = 150;
    var yIndex = 200;

    for (var i = 0; i < height; i++) {
        for (var j = 0; j < width; j++) {
            var rect = two.makeRectangle(xIndex, yIndex, squareLength, squareLength);
            rect.stroke = "blue";
            rect.fill = b[i][j];
            two.update();
            xIndex += squareLength;
        }
        xIndex = 150;
        yIndex += squareLength;
    }
}

function drawGameBoard(b, squareLength) {
    if (!two) initalizeTwo();
    if (b !== null && b.Data !== null && b.Data.length > 0 && b.Data[0].length > 0) {
    var board = b.Data;

     var width  = 0;
    var height = 0;

    var xIndex = 150;
    var yIndex = 200;

    height = board.length;
    for (var i = 0; i < height; i++) {
        width = board[i].length;
        for (var j = 0; j < width; j++) {
            var rect = two.makeRectangle(xIndex, yIndex, squareLength, squareLength);
            rect.stroke = "blue";
            var color = "black";
            if (board[i][j] == null) color = "white"
            else color = colorDictionary[board[i][j]];
            rect.fill = color;
            two.update();
            xIndex += squareLength;
        }
        xIndex = 150;
        yIndex += squareLength;
    }

    }
}


function drawWindowArt(left, top, direction) {

    if (!two) initalizeTwo();

    for (var i = 0; i < 5; i++) {
        var line = two.makeRectangle(left, top, 45, 50);
        line.linewidth = 5;
        var randomColor = colors[getRandomIntInclusive(0, 4)];
        line.stroke = randomColor;
        switch (direction) {
            case 0:
                left += window_width;
                top -= window_width;
                break;
            case 1:
                left -= window_width;
                top -= window_width;
                break;
            case 2:
                left -= window_width;
                top += window_width;
                break;
            case 3:
                left += window_width;
                top += window_width;
                break;
        }
        line.fill = colors[getRandomIntInclusive(0, 4)];
    }
}

function drawRects() {
   
    var left = 200;
    var top = 250;

    for (var turn = 0; turn < 4; turn++) {
        drawWindowArt(left, top, turn);
    }

    // to the screen
    two.update();
}

function drawGamakichi() {
    if (!two) initalizeTwo();

    //clear canvase
    two.clear();

    // Make ellipse
    var ellipse = two.makeEllipse(150, 200, 65, 55);
    ellipse.linewidth = 0;
    ellipse.fill = "red";

    // Make star
    var star = two.makeStar(150, 200, 45, 15, 4);
    star.linewidth = 0;
    two.update();
}

function drawPolygon(sides) {
    if (!two) initalizeTwo();
    two.clear();

    var poly = two.makePolygon(150, 200, 15, sides);
    poly.fill = "blue";



    two.update();
}

var unitWidth = 20;
var centerX = 150;
var centerY = 200;

function drawPentominoeL() {
    if (!two) initalizeTwo();
    two.clear();
    var group = two.makeGroup();

   
    var poly = two.makeRectangle(centerX, centerY, unitWidth, unitWidth*4);
    poly.fill = "blue";
    group.add(poly);

    var poly2 = two.makeRectangle(centerX + unitWidth, centerY + (1.5 * unitWidth), unitWidth, unitWidth);
    poly2.fill = "blue";
    group.add(poly2);
    two.update();
}

function drawPentominoeP() {
    if (!two) initalizeTwo();
    two.clear();
    var group = two.makeGroup();

    var poly = two.makeRectangle(centerX, centerY, unitWidth * 2, unitWidth * 2);
    poly.fill = "blue";
    group.add(poly);

    var poly2 = two.makeRectangle(centerX - (.5 * unitWidth), centerY + (1.5 * unitWidth), unitWidth, unitWidth);
    poly2.fill = "blue";
    group.add(poly2);

    two.update();
}

function drawPentominoeX() {
    if (!two) initalizeTwo();
    two.clear();
    var group = two.makeGroup();

    var poly = two.makeRectangle(centerX, centerY, unitWidth * 3, unitWidth);
    poly.fill = "blue";
    group.add(poly);

    var poly2 = two.makeRectangle(centerX, centerY - unitWidth, unitWidth, unitWidth);
    poly2.fill = "blue";
    group.add(poly2);

    var poly3 = two.makeRectangle(centerX, centerY + unitWidth, unitWidth, unitWidth);
    poly3.fill = "blue";
    group.add(poly3);

    two.update();
}

function drawPentominoeF() {
    if (!two) initalizeTwo();
    two.clear();
    var group = two.makeGroup();

    var poly = two.makeRectangle(centerX, centerY, unitWidth , unitWidth*3);
    poly.fill = "blue";
    group.add(poly);

    var poly2 = two.makeRectangle(centerX-unitWidth, centerY, unitWidth, unitWidth);
    poly2.fill = "blue";
    group.add(poly2);

    var poly3 = two.makeRectangle(centerX+unitWidth, centerY-unitWidth, unitWidth, unitWidth);
    poly3.fill = "blue";
    group.add(poly3);

    two.update();
}

function drawPentominoeV() {
    if (!two) initalizeTwo();
    two.clear();
    var group = two.makeGroup();

    var poly = two.makeRectangle(centerX, centerY, unitWidth, unitWidth * 3);
    poly.fill = "blue";
    group.add(poly);

    var poly2 = two.makeRectangle(centerX + (1.5*unitWidth), centerY+unitWidth, unitWidth * 2, unitWidth);
    poly2.fill = "blue";
    group.add(poly2);

    two.update();
}

function drawPentominoeU() {
    if (!two) initalizeTwo();
    two.clear();
    var group = two.makeGroup();

    var poly = two.makeRectangle(centerX, centerY, unitWidth* 3, unitWidth);
    poly.fill = "blue";
    group.add(poly);

    var poly2 = two.makeRectangle(centerX - unitWidth, centerY - unitWidth, unitWidth, unitWidth);
    poly2.fill = "blue";
    group.add(poly2);

    var poly3 = two.makeRectangle(centerX + unitWidth, centerY - unitWidth, unitWidth, unitWidth);
    poly3.fill = "blue";
    group.add(poly3);

    two.update();
}

function drawPentominoeW() {
    if (!two) initalizeTwo();
    two.clear();
    var group = two.makeGroup();

    var poly = two.makeRectangle(centerX, centerY, unitWidth * 2, unitWidth);
    poly.fill = "blue";
    group.add(poly);

    var poly2 = two.makeRectangle(centerX - (.5 * unitWidth), centerY - unitWidth, unitWidth, unitWidth);
    poly2.fill = "blue";
    group.add(poly2);

    var poly3 = two.makeRectangle(centerX + unitWidth, centerY + unitWidth, unitWidth * 2, unitWidth);
    poly3.fill = "blue";
    group.add(poly3);

    two.update();
}

function drawPentominoeY() {
    if (!two) initalizeTwo();
    two.clear();
    var group = two.makeGroup();

    var poly = two.makeRectangle(centerX, centerY, unitWidth, unitWidth * 4);
    poly.fill = "blue";
    group.add(poly);

    var poly2 = two.makeRectangle(centerX - unitWidth, centerY - (.5 * unitWidth), unitWidth, unitWidth);
    poly2.fill = "blue";
    group.add(poly2);


    two.update();
}

function drawPentominoeI() {
    if (!two) initalizeTwo();
    two.clear();
    var group = two.makeGroup();

    var poly = two.makeRectangle(centerX, centerY, unitWidth, unitWidth * 5);
    poly.fill = "blue";
    group.add(poly);

    two.update();
}

function drawPentominoeT() {
    if (!two) initalizeTwo();
    two.clear();
    var group = two.makeGroup();

    var poly = two.makeRectangle(centerX, centerY, unitWidth, unitWidth * 3);
    poly.fill = "blue";
    group.add(poly);

    var poly2 = two.makeRectangle(centerX - unitWidth, centerY - unitWidth, unitWidth, unitWidth);
    poly2.fill = "blue";
    group.add(poly2);

    var poly3 = two.makeRectangle(centerX + unitWidth, centerY - unitWidth, unitWidth, unitWidth);
    poly3.fill = "blue";
    group.add(poly3);

    two.update();
}

function drawPentominoeZ() {
    if (!two) initalizeTwo();
    two.clear();
    var group = two.makeGroup();

    var poly = two.makeRectangle(centerX, centerY, unitWidth, unitWidth * 3);
    poly.fill = "blue";
    group.add(poly);

    var poly2 = two.makeRectangle(centerX - unitWidth, centerY - unitWidth, unitWidth, unitWidth);
    poly2.fill = "blue";
    group.add(poly2);

    var poly3 = two.makeRectangle(centerX + unitWidth, centerY + unitWidth, unitWidth, unitWidth);
    poly3.fill = "blue";
    group.add(poly3);

    two.update();
}


function drawPentominoeN() {
    if (!two) initalizeTwo();
    two.clear();
    var group = two.makeGroup();

    var poly = two.makeRectangle(centerX, centerY, unitWidth, unitWidth * 3);
    poly.fill = "blue";
    group.add(poly);

    var poly2 = two.makeRectangle(centerX + unitWidth, centerY - (1.5 *unitWidth), unitWidth, unitWidth *2);
    poly2.fill = "blue";
    group.add(poly2);

    
    two.update();
}