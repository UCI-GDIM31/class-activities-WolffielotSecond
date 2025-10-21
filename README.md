# in-class-activities

## Devlogs

### W1

Write your W1 activity Devlog here.

### W2

Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

## W3

**Class Activity(Table 1):**

**1**

bool whether\_Hit(float Finger\_Hit, folat Finger\_Leave){

 	bool hit = Mathf.abs(Finger\_Hit - Should\_Hit) <= 0.1 \&\& Mathf.abs(Finger\_Leave - Should\_Leave) <= 0.1;

 	return hit;

}

//Finger\_Hit, Finger\_Leave is the time when player's finger hits or leaves the screen, and Should\_Hit and Should\_Leave are values that are the precise time that player should touch the screen.

2 Mono blahblah questions

(1) a class is a blueprint and a component is the thing made from the blueprint.

(2) the RGB values approaches 1, and (1, 1, 1) is white

## W4

Line 5 is a member variable, a float variable specifically, setting the value to 1.

Line 22 computes the translation distance when the player presses W and S, the translation is input direction times speed times frame time. translation is a local variable in the method Update, which Unity process it in every frame time. Input is a class and GetAxis is a method in that class to get the player controller movement axis. \_moveSpeed is float member variable on line 5, and deltaTime is a variable in the Time class.

Line 25 implements the translation of the player character forward or backward based on the player's input from the calculation on line 22. It calls the Translate method in the transform class to move the player character.



\#Q1

By adding the Rigid body component to the soccer and the cat. And adding the trigger on the goal.

\#Q2

Only that the cat rotates in a weird way, but it is fixed by locking the x and z rotation.



## Open-Source Assets

### W1

* Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727
* Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153
