# Practical 4.2 Implementing the Cameras for a Racing Game

In the lecture, you learned about cameras and how they allow us to view Unity Scenes. In this practical, you are going to use cameras to implement several different views of a car racing game.

By the end of this practical you will be able to:

- Create and position a static camera in a scene
- Create follow-cam and ‘dungeon crawler’ third person cameras
- Manipulate the viewports of multiple cameras to create a split-screen effect

This repository includes a Unity project with a basic racing game that you’ll extend in this class. To get started make a copy of this repository on your GitHub account and clone it onto your local computer.

## Task 1: Opening and Exploring the Racing Game

Get started by opening the SimpleRacingGame scene, which you will find in the root directory of the project browser. Explore the scene. You’ll see that the scene comprises a simple off-road racing track terrain and a racing car.

## Task 2: Static Camera

The SimpleRacingGame scene contains no camera. Therefore, nothing is seen when the play button is pressed in the Unity editor.

Your first task is to create a static camera that is oriented towards initial position of the car. Once you’ve created this camera, experiment with driving the car using the following controls:

- Steering: A/D keys
- Accelerate/Brake: W/S keys

## Task 3: Follow Camera

In this task, you should create a third person follow camera for the car. This follow camera should: be positioned at an offset from the car so that the model is visible, always points in the direction of the car, and has the same orientation as the car.

To complete the task, experiment with the position and orientation of the camera, to find a configuration that looks good and allows you to see where the car is going.

## Task 4: Top-Down Camera

In this task, you should create a top-down camera. This camera should follow the car from above, while maintaining a constant orientation. The result should look like the camera view in the classic racing game Micro Machines (see https://youtu.be/9d1fp2LRHog). That's to say, it should move, but not rotate, with the car. 

To help you with this you may like to look at the "dungeon crawler" camera instructions in the lecture. 

To make it easier for the player to steer, you may want to make the camera show a wider view of the scene as the speed increases. 

## Task 5: Split-screen Multiplayer

In the final task today, you are going to create a split-screen multiplayer view, which allows multiple cars to be driven at once in a race. The result should look something like the split screen view in Mario Kart: https://youtu.be/G-yNrP7TWP4

To begin this task, create two (or more) cars by duplicating the car object in the hierarchy. To allow the cars to be driven independently of each other, you will need to change the control axis public string variables (“Steering Axis” and “Acceleration Brake Axis”) of the Car User Control script so that they are different for each car.

You can edit input settings by going to Edit > Project Settings > Input Manager. You will see that I have two inputs custom named to "LeftStick" and "Triggers". You can duplicate these or alter other inputs to allow for two cars to be controlled with one keyboard. 

Once you have multiple cars that you can control independently, create the split screen effect by: creating a third person follow camera for each car and setting its viewport to an appropriate region on the screen.

## Optional Extensions

If you complete all the above tasks before the end of the practical, consider the following tasks:

- Make your static camera from task 2 follow the car around the scene using the LookAt function in a script https://docs.unity3d.com/ScriptReference/Transform.LookAt.html
- Modify your follow camera, so it's up axis is always aligned with the up axis of the world, in order to reduce the potentially nauseating motion you might have noticed when your car rolls from side to side.
- Create a first-person camera with a rearview mirror that shows what is behind the car.
- Write a script that allows you to switch between multiple cameras using a key on keyboard, see: http://docs.unity3d.com/ScriptReference/Camera-allCameras.html.
