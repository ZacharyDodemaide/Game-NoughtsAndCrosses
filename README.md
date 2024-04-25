How to play
1. Open Terminal.
2. Navigate to the project folder’s root directory.
    - Run the following commands: dotnet build > dotnet run (requires .Net 6 to build)
3. The game starts as Human vs. Computer (the only mode implemented).
    - The 3x3 board has both axes starting at 0 and ending at 2:
4. In the terminal, players make moves by entering Row number, Column number, and 
Token x or o (token is case insensitive).
5. After a successful move, the computer opponent responds, and repeat from 4, until a 
player wins. 
6. If an invalid move is made, the player will be prompted of an invalid move followed 
by the instructions prompt.
