# Rock, Paper, Scissors

#### A program that allows users to challenge a friend to a game of 'Rock, Paper, Scissors.' 5/31/17

#### By **Marilyn Carlin and Jared Luedtke**

## Description

A website created with C#, HTML, and CSS where a user can challenge a friend to a game of 'Rock, Paper, Scissors' using radio buttons to select from the three standard choices.


### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Homepage** | User accesses localhost:5004 | Homepage with selectors for each player to select 'Rock,' 'Paper,' or 'Scissors' |
| **Player 1 Input** | User selects from three radio buttons | Form submits user selection |
| **Player 2 Input**| Second user selects from three radio buttons | Form submits user selection |
| **Tie**| Users select same option | Page displays: "Tie!" |
| **Player 1 Wins** | Player1: Rock, Player2: Scissors | Page displays: "User One Wins!" |
| **Player 2 Wins** | Player1: Rock, Player2: Paper | Page displays: "User Two Wins!" |

## Setup/Installation Requirements

1. To run this program, you must have a C# compiler. I use [Mono](http://www.mono-project.com).
2. Install the [Nancy](http://nancyfx.org/) framework to use the view engine. Follow the link for installation instructions.
3. Clone this repository.
4. Open the command line--I use PowerShell--and navigate into the repository. Use the command "dnx kestrel" to start the server.
5. On your browser, navigate to "localhost:5004" and enjoy!

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#
  * Nancy framework
  * Razor View Engine
  * ASP.NET Kestrel HTTP server
  * xUnit

* HTML
* CSS
  * Bootstrap

## Support and contact details

_Email no one with any questions, comments, or concerns._

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2017 **_{Marilyn Carlin, Jared Luedtke}_**
