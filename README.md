# EPXCamp-Sept1-2018
A project for a quick &lt; 30minute introduction to Unity/programming

1. Overview of the Unity UI
![Unity UI](https://cdngamedevacademy.azureedge.net/wp-content/uploads/2017/01/unity-ui.png?x92588)
a. Project Window -- think of this like the File Explorer of your game project. The files *exist* and can be referenced but they don't show up in game unless you insert them.
b. Hierarchy Window --
c. Scene View --
d. Game View --
e. Toolbar --
f. Inspector --

2. Add Assets to our Project: Unity comes with lots of free assets which take the hassle out of coding/modeling/etc. We'll use one now, called Character, which manages our code for movement. To import this: In the Toolbar, click through Assets > Import Packages > Characters > OK. We'll take everything from the default import for now, we'll likely use them in a bigger project.

3. We want to add one of the character objects now. In the Project Window, click through the folders of Assets >Standard Assets > Characters > FirstPersonCharacter > Prefabs, and drag RigidBodyFPSController onto the Scene View.
a. Why RigidBodyFPSController as opposed to FPSController? (Explain RBs)
b. What's a Prefab?
c. How do I know what these do? How do I know what assets there are?

4. You'll now see two camera icons on the scene -- that's because we start out with a basic 3rd person camera, and we now have the built-in 1st person camera. Right click on the "Main Camera" on the Hierarchy Window and delete it.

(STOP AND REFLECT) Hit play, try to move around, what happens, why does that happen?
Answer: We have gravity in this game via the RigidBody, but we don't have a ground, so we fall eternally. We don't want that, we need ground!

5. Right click on the hierarchy > 3d object > plane, make it like a little beneath your fpscontroller, and big enough for your terrain (10x1x10). Hit play, you can walk around now. Yay :)

6. We want to add an item now, an enemy or a power up, maybe. Right click on Hierarchy > 3D Object > Cube. Then, click on the cube, in the inspector panel > Add Component > New Script > SpinnyFloatyCube, C# > Create and Add

7. Rotational Script 
a. Time.Delta Time
b. Speed Variable.
i. Public Vs Private

8. Collision 
a. OnCollisionEnter
b. If/Else
c. How to get player object
d. Colliding with object vs floor

9. Spawning Cubes for interest: right click in hierarchy > create empty, select that new object > Add Component > New Script > Spawner
i. Why empty, what is empty?

10. Getting Input
