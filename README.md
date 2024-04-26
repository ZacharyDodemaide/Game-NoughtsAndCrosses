# Read Me
Noughts and crosses played between a human and the computer in the terminal.

## Prerequisites
- .NET 6 (for building the project)

## Running the Game
1. Open your terminal.
2. Navigate to the project's root directory using the cd command.
3. Run the following command to build and start the game:
    - dotnet build
    - dotnet run 
## Gameplay
The game board is a 3x3 grid where both rows and columns are numbered from 0 to 2. You make moves by entering a row number (0, 1, or 2), a column number (0, 1, or 2), and your desired token ("X" or "o"). Tokens are not case-sensitive. After a valid move, the computer will make its response. The game continues until a player gets three tokens in a row (horizontally, vertically, or diagonally) or all squares are filled (resulting in a tie).

If you enter an invalid move, the game will prompt you with an error message and ask you to try again.
