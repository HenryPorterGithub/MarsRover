function MoveRover(xStart, yStart, dStart, MoveMR, spanOutput) {

    let Direction = dStart;
    let [X, Y] = [xStart, yStart];
    let ActionCount = MoveMR.length;

    //Perform movement actions with two helper functions
    for (let i = 0; i < ActionCount; i++) {

        let Command = MoveMR[i];

        if (Command == "M") {
            [X, Y] = DoMovement(Direction, [X, Y]);

        } else {
            Direction = ChangeDirection(Direction, Command);
        }

    }

    //Declare output string and map it to an HTML span
    let strOutput = 'X=' + X.toString() + ',' + 'Y=' + Y.toString() + ',' + Direction;
    document.getElementById(spanOutput).textContent = strOutput
}

function ChangeDirection(OldDirection, LR) {

    //Change old direction to a new one with a switch statement

    let NewDirection;

    switch (OldDirection) {
        case "N":

            if (LR == "L") {
                NewDirection = "W";
            }
            if (LR == "R") {
                NewDirection = "E";
            }

            break;

        case "E":

            if (LR == "L") {
                NewDirection = "N";
            }
            if (LR == "R") {
                NewDirection = "S";
            }

            break;

        case "S":

            if (LR == "L") {
                NewDirection = "E";
            }
            if (LR == "R") {
                NewDirection = "W";
            }

            break;

        case "W":

            if (LR == "L") {
                NewDirection = "S";
            }
            if (LR == "R") {
                NewDirection = "N";
            }

            break;
    }

    return NewDirection;

}

function DoMovement(Direction, [X, Y]) {

    //Move +/- 1 on the proper axis depending on orientation

    switch (Direction) {
        case "N":
            Y += 1;
            break;
        case "E":
            X += 1;
            break;
        case "S":
            Y -= 1;
            break;
        case "W":
            X -= 1;
            break;
    }

    return [X, Y]
}