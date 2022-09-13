# streamWriter

this shows how to use a StreamWriter and StreamReader to write to a file and then read from the same file, on MAC.

also how to create a directory.

This is in preparation for creating a save game system in a game:
1. save: text file is written with stats on a different lines
- writer should stay open, for resaving and closed only when exiting game
2. load: read the text file with stats on different lines
- reader should stay open, for reloading and closed when exiting game
