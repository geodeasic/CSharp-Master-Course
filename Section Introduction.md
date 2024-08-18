# Section Introduction
In this section, we start our programming journey by:<br>
1. Creating our first app <br>
2. Learning how use the most basic programming concepts such as variables, methods, conditional statements, arrays, loops, etc. <br>
3. Learning how to use Visual Studion effectively <br>
4. Learning CLEAN code be implementing two simple assignments.<br>

## Our First App
### Overview
This application will be a simple Console application that can be used to manage a simple TODO list. 
Each TODO has the following basic requirements:<br>

1. Contains a unique description of the TODO item.
2. Can be added, removed, or listed.

### Main Application Workflow
1. Prints a simple greeting message.
2. Prompts the user to perform an operation with the 
message: "What would you like to do?"
3. The user has four options represented by the 
following single characters:<br>
[L]ist all TODO items<br>
[A]dd a TODO item<br>
[R]emove a TODO item<br>
[E]xit the application<br>

<b>Note:</b> The character typed in should not be case 
sensitive and the user can contonue to type in L, A, or R 
until they type in E to exit the application.<br>

### Selecting an Option
|Scenario|User Action|Result|
|:-------|:----------|:-----|
|Correct input|User selects L, l, A, a, R, r, E, or e|The correct option is handled. After it is finished, the choice of options is printed again (unless the Exit option was chosen, in which case the application exits).
|Incorrect or empty input|User enters nothing or a empty space.| The message: “Incorrect input” is displayed on the screen. Then, the selection of choices is printed again. this is repeated until the user provides the correct input.

### "L" Option - Lists all TODO items
A list of all TODO items shall be printed to the console, 
all prefixed with an index number (starting from 1) followed 
by a period (.). Example:<br>

1. Plan for my up-coming birthday party.
2. Meet my friends this afternoon.
3. Book a train to Mombasa.

|Scenario|User Action|Result|
|:-------|:----------|:-----|
|Correct input|User selects L or l|All TODO items are displayed on the screen and the options are displayed.
|There are no TODO ietms| | The message: “No TODO items have been added yet.” is printed to the console and the options are displayed.

