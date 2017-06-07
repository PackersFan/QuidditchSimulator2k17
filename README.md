# QuidditchSimulator2k17

This is a project to create a web text-based game that is a simulation of Quidditch. Quidditch is a sport from Harry Potter that is also played in real life at different universities, such as the College of Charleston. This game will be created using the USQ rulebook, but will feature magical aspects and be more similar to the way the game is run in the books/movie. Kind of a blending of both worlds. 

**TODO LIST**:

    1. Create functionality to register a new team and insert into Database
        **Status (5/27/17): Rough ability to add team is complete. Currently, hard coded values are present for captain, region, and
        player count just so the feature could be finished. Next step to fully flesh out this is to get players pulled back as well as
        regions pulled back - both of which won't be too hard to do - then it will be fully implemented (as baseline as it needs to be for         now).
        **Status (6/7/17): Team hub page is now created. Right now, it has buttons (that do not function) to bring you to the draft
        page, the roster page, and the simulation page. Also, the roster page is in progress as a simple table that will dump the players         on the given team to it. Next steps are to identify a ranking system to allow for one player to be considered "better" then 
        another for what the users would want to pick. Fun stuff!
    2. Create functionality to draft pre-created players into your team
    3. Create functionality to simulate a game vs another pre-created team 

Once these goals are reached, I have a few other immediate things I would like to add:
  
    1. Functionality to create a custom player 
    2. Functionality to play a season of X amount of games
    3. Once seasons are implemented, add fun "random events" or storylines
    
Additionally, I need to identify a system to simulate the games based on the USQ rules. I will probably end up going with a stat-based system for the players and then writing some code by hand or finding a simulation system out there that I can tweak to make it "random-ish". 
