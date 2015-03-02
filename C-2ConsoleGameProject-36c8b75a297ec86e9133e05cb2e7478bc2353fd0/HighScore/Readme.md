1.
int Add(int pts, string name = null) 

This method adds points to the highscore list.
If name is null or string.Empty - this method will ask for name.

The result is: 
int(-1) for adding new score outside the list.
int(position) for new position in the highscore.

2.
string PrintPoints_WithPosition(int pos = -1)

This method creates string with current highscore list.
If pos = -1  the text " <-- This is your new highscore!" will not be printed.

The result is:
string(all_highscores) String with all Highscores. (includes new lines).