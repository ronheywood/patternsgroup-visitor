# Factory Method

This is a sample Windows Console app
used while discussing the Factory Method during a Gang Of Four pattens group session.

The basic MazeGame "MakeMaze" method adds a number of walls and a room.

If we want to add other types of Maze, we could subclass the MazeGame and override the MakeMaze method, but this would mean duplicating all of the code required to setup the Maze.

Demonstrate how a FactoryMethod can be used to override Make methods by defining the top level Factory method in an abstract class.

# Usage

command line: MazeGame\bin\Debug\MazeGame.exe