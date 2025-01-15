[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
https://docs.google.com/document/d/1L3htDZweErSKUt-toXfU5QO7hGO1l16p51hTYUGWM0U/edit?usp=sharing - class notes


## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


My plan went almost the same as how I had it planned out. All my game objects first needed to be placed into the scene then and given the provided scripts. After adding the script components I filled the required values, gameobjects and UI. First thing I tackled was player movement, with a simple reference from the Transform  _playerTransform placed within a if loop with if input is WASD _playerTransform.position to a vector corresponding to up, down, left and right. 

Next I worked on PlantSeed() knowing the player would need to plant a seed at the player's position and then add to the number of plants planted and take away the number of seeds left. To keep the number of plants from going over the amount of seeds I put in an if loop, if the number of seeds is greater than zero, PlantSeed() can continue to be called. Within the function I Instantiate the prefab so it can be spawned in then referencing playerTransform.position to spawn in at the players position and then added in Quaternion.identity to keep the rotation with the scene. I then added GetKeydown space so whenever the spacebar was pressed PlantSeed() was called and played a plant.

Finally I set up the plant counter UI first referencing both text variables to print out the seeds left and seeds planted. After I went back into the Player script set numSeedsLeft equal to numSeeds  then added in plantCounterUI.UpdateSeeds filling in the two required variables for seeds left and seeds planted. I finished with adding numSeedsPlanted++ and numSeeds- - in PlantSeed() so when called upon numSeedsPlanted will go up by one and numSeeds go down by one. Referenced to plantCounterUI.UpdateSeeds displayed the number of plants and seeds left.




## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
