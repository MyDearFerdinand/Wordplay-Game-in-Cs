Wordplay Game in C#

Overview
This project hosts a simple yet entertaining wordplay game written in C#. It allows the user to engage in a word scramble exercise where they are tasked to unscramble a given set of letters to form a meaningful word.

Gameplay
Upon starting the game, a word is randomly picked from a predefined list of words, which includes various fruits like "apple", "banana", "grape", "orange", "peach", "cherry", "strawberry". This chosen word is scrambled by randomly shuffling its letters, and the scrambled version is presented to the player.
The player is then prompted to guess the original word. The game provides real-time feedback, encouraging the player to try again if the guess is incorrect, or congratulating them for guessing the word correctly.

Features
- Word Scrambling: The words are scrambled effectively using a random ordering function.
- User Interaction: The game features simple yet intuitive command line interactions.
- Replayability: The game can be replayed indefinitely until the user guesses the word correctly.

Usage
Run the Program.cs file in any C# environment to start the game. After you see the scrambled word on the console, type your guess and press Enter. The game will guide you through the rest of the steps.

Future Enhancements
While this game currently uses a predefined list of words, future enhancements could include:
- More complexity by adding larger words or a larger dictionary to pick words from.
- A hint feature that gives the player the category of the word or the first letter.
- A scoring system based on how many tries it took to guess the word.
- Integration with an API to fetch a random word for scrambling.
