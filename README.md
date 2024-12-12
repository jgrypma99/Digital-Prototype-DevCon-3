# Digital-Prototype-DevCon-3
 
# Devcon 3 - Physics in Unity

## Soft Body Simulation in Unity
Objective - Believably simulate a soft body material (in our case a jelly-like slime) in the Unity 3D game engine by utilizing rigid bodies and spring joint systems.

## Overview - Game Pitch and Rationale
Our idea was to utilize gravity and the physics system to create a puzzle game in which players guide slimes of different colours to fall onto matching coloured slimes in order to earn points in a similar manner to games such as tetris. Slimes of different sizes and colours (initially Red, Green, and Blue) would continuously spawn from the top of the play area and fall towards the bottom, as the slimes fall the player would have some degree of control over their horizontal movement along the X-Axis in order to place them with the matching colour. Gameplay would take place from a fixed camera perspective showing a front view of the play area as slimes fall from above. Initially only three colours of slime were present in the game (the aforementioned Red, Green, and Blue,) but as we tested our concept we found it was too simple with only three colours so we added an additional three, (Cyan, Yellow, and Magenta.)

## Development
As soft body simulation is not natively supported in the Unity game engine it was necessary for us to figure out a way to fake it with the tools present in Unity. This was accomplished through the use of higher poly spheres created and rigged in Blender with bones placed along each axis and applying rigid bodies to each spring which were then used as the Connected Body in spring joints and then playing with the mass and gravity until it felt right. Through this method we were able to satisfyingly fake soft body simulations.

## Citations
https://www.youtube.com/watch?v=LHtGs66lui8 - Tutorial for Soft Body physics in Unity
