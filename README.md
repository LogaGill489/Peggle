<h1>Peggle</h1>
<hr>
Peggle is a 2D game developed in C# using Visual Studio 2022 that was inspired by the original 2007 game of the same title. The game features a custom, 2D phyiscs engine created entirely without the use of any external libraries, handling motion, dynamic collisions, and gravity.

The collision algorithm was created using derivative logic, running continuously within the game loop. I also made use of object-oriented programming for the pegs, the ball, and keeping track of the score. This was by far the most technically challenging game I've worked on, as it required recreating physical forces in a simplified, 2D environment. Despite the difficulty, it pushed me to consider how these forces could be realistically approximated, and I'm quite happy with the result.

Physics engine included in the ball.cs class. Main game screen runs the game using a few timers. Enjoy!
