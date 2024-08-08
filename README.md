# Refuge_Redo
**Contents**  
[1. Info](#info)  
[2. Goal](#goal)  
[3. Results](#results)  
[4. Process](#process)  
[4.1 Player Controller and Camera](#player-controller-and-camera)  
[4.2 Level Layout / Design](#level-layout--design)  
[4.3 Terrain Editor](#terrain-editor)  
[4.4 Attention to Detail](#attention-to-detail)  
[5. Narrative](#narrative)  
[6. Controls](#controls)  
[7. Links](#links)  


## Info
**Date:** July - August 2024

Made in Unity.  

**TLDR:**  
This is a redesign of a level design I did in my sophomore year of college.  

## Goal
Preserve the essense of the original design, but clean it up and make it more cohesive.

## Results
View at the start of the level. The player is at the pavilion and looking towards the hedge maze.  

![alt text](Screenshots/Refuge_Redo_1.png)  

View from the top of the lighthouse. The player is looking down at the hedge maze and pavillion.  

![alt text](Screenshots/Refuge_Redo_2.png)  

View from the top of the hill the player gets teleported to. The player is looking out at the hilly area and ruins.  

![alt text](Screenshots/Refuge_Redo_3.png)  

View from inside the ruined village. The player is looking at the main ruined house in the distance with a glowing throne.  

![alt text](Screenshots/Refuge_Redo_4.png)

## Process
### Player Controller and Camera
First thing that I wanted to fix from the original version was the player controller and camera. The goal for this was to just make them smoother and feel better to use.  
This time around I used a combo of a "Character Controller" compoenent and a Cinemachine "Free Look" camera to achieve this.   

### Level Layout / Design
The Next glaring issue was the synergy of some parts of the level design so I revisited the original design and swapped out some areas.  
The first area to change was the starting area (the house and maze in the original). The combination of those two, frankly, did not make any sense. I ended up with a pavilion and a hedge maze which I think can be narratively tied together easier.  
The next section to be changed was the random ramps up a giant wall to jump off of. Again it just didn't make sense. What could be a tall object I could add, to jump off of? I landed on a lighthouse, which could also serve as a big beacon in the background for players to move towards.  
The last two sections (the hills and ruined village) conceptually stayed the same, just got major facelifts.

### Terrain Editor
This time around I decided to use as much as Unity offered as I could, meaning using the terrain editor for the first time.  
In the original, I struggled to make the hills terrain and ended up making these obtuse boxy hills that didn't feel natural at all. You couldn't even tell what they were by looking at them. (I didn't know what Unity had a terrain editor.)  
This time I crafted natural hills and a valley with the terrain editor in a fraction of the time it took me to make the original "hills".

### Attention to Detail
One of the things I made sure to put a lot of effort into this project is attention to detail. In the original so much of the geometry had noticable seems and some clipping issues. A lot of the objects you could not tell what they were by looking at them.  
So, I spent time making sure the objects I was whiteboxing didn't have those issues.

## Narrative
If I had to put a narrative to this level it would be something like this:  
The player is shrunk down to a miniture size and has to navigate a magical miniture set.

## Controls
The controls for the project:  
WASD - movement  
QE   - tilt camera up or down

## Links
[My Portfolio](https://github.com/ksanti6/portfolio)  
[The Original Version of this Project](https://github.com/ksanti6/portfolio/blob/main/DESIGN/Designing_A_3D_Whitebox_Level/Refuge_3D_Whitebox_Level.md)  
