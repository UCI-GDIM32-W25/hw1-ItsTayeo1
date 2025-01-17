[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
How would you describe this game world in objects?
- Objects 
  - UI
    - Seeds planted UI
    - Seeds remaining UI
  - Player
    - Movement 
  - Plant
 
What attributes and actions do these objects have?
- UI
  - Seed counter 
    - Counts the seeds remaining 
    - Attributes: test
    - actions : count goes up when player plants a seed
  - Plant counter
    - Counts the plants on screen planted 
    - Attributes: text
    - Actions: count goes down when player plants a seed
- Player
  - Attributes 
    - Bunny sprite
  - Movement
    - Input - WASD keys
    - Output - player changes location
  - Planting seeds
    - Input - press spacebar
    - Output - Plants a plant

How do these objects act on or affect each other?
- UI
  - Seed counter goes down as Plant counter goes up 
- Player
  - Action of spacebar to plant affects both counters
  - Seed counter only allows player to plant as many plants as there are seeds to do so

## Devlog
My plan went almost the same as how I had it planned out. All my game objects first needed to be placed into the scene then and given the provided scripts. After adding the script components I filled the required values, gameobjects and UI. First thing I tackled was player movement, with a simple reference from the Transform  _playerTransform placed within a if loop with if input is WASD _playerTransform.position to a vector corresponding to up, down, left and right. 

Next I worked on PlantSeed() knowing the player would need to plant a seed at the player's position and then add to the number of plants planted and take away the number of seeds left. To keep the number of plants from going over the amount of seeds I put in an if loop, if the number of seeds is greater than zero, PlantSeed() can continue to be called. Within the function I Instantiate the prefab so it can be spawned in then referencing playerTransform.position to spawn in at the players position and then added in Quaternion.identity to keep the rotation with the scene. I then added GetKeydown space so whenever the spacebar was pressed PlantSeed() was called and played a plant.

Finally I set up the plant counter UI first referencing both text variables to print out the seeds left and seeds planted. After I went back into the Player script set numSeedsLeft equal to numSeeds  then added in plantCounterUI.UpdateSeeds filling in the two required variables for seeds left and seeds planted. I finished with adding numSeedsPlanted++ and numSeeds- - in PlantSeed() so when called upon numSeedsPlanted will go up by one and numSeeds go down by one. Referenced to plantCounterUI.UpdateSeeds displayed the number of plants and seeds left.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for connecting your break-down to the code you wrote. :)

Next time, please put your break-down actually in the Devlog text instead of just linking it. You can format your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).

Also, you repeatedly called "for loop"s an "if loop" - be careful, because I can take points off for misusing technical terms! I'll let that slide this time.
