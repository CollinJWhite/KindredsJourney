This file is Sprint 0 for Ohio States CSE 3902 Course
-------------------------------------------------------------

It features Mario and allows the user to move him around in the following ways:

W - Walk forward
A - Walk to the left
S - Walk down
D - Walk to the right

Left Click - Teleport Mario to the cursor

Esc - Quit

I used AI primarily to handle both Sprites and the Idle logic; For the sprites, I used to it make the WalkingXDirectionSprites as well as the delegating logic in KindredSpriteState.cs. It serves as an abstract class to make the different sprites a matter of adjusting the Rectangle. For the idle animation, I didn't want to pass the whole player object into the controllers just for that, so AI helped me find the other say I could get the IdleAnimation separately - by passing the Command into the controllers, it both allows me to set the state to idle while keeping the properties of the player outside of the controllers reach.

All files and references used for this implementation can be found on the Carmen Canvas page - Sprint 0 for the references to MonoGame logic and the "gameresources.html" file in the Carmen Files section.
