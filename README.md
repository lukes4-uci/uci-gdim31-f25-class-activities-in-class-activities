# in-class-activities

## Devlogs

### W1



Hello world. this is my first gmae yesesy



### activity 1

our group tried to find games we had in common, but it just devolved into henri giving game recommendations from her frankly enormous steam library



### activity 2

#### 
1. moving the camera off of the cat makes unlinks it from the cat GameObject, so moving the cat does not move the camera. thus, the camera becomes stationary, while the cat continues to move according to the player's input. 

#### 
2. itch link: https://lukes4-uci.itch.io/lukes4-w1-activity 



### W2

1. The RGB scale being used goes from 0.0 to 1.0, so decimal points are necessary in order to measure different levels of red, blue, and green colours. Ints, bools, and strings cannot handle decimal points, but floats can.

2. The number of bounces can be measured without decimal points, so floats are not needed. Bools can only handle true or false statements, while strings include only text and so using it to handle numbers becomes much harder than just using integers.

3. The line of code was not ended with a semicolon, which resulted in a syntax error. The exact line is: "error CS1002: ; expected"


### W3
table #2
#### activity 1
1. String GetResponse(int choice, int friendshipLevel, bool secret)
2. void SetLightDimness(int sanityLevel)
3. bool DidPlayerHitBeat(float accuracy)

#### activity 2
Class: Taco shell
Compoenent: Full taco (from Taco Bell)
Member variables: Ingredients
Methods: How you want the taco

#### activity 3 part 3
the brightness variable that is being modified does not have any in-method caps. they will keep on increasing in brightness until they reach the maximum possible values. 

### W4
1. Cat and SoccerBall have RigidBodies, since they must interact with each other in a way that involves physics. Goal has IsTrigger since SoccerBall must pass through it and trigger a signal to increase points.
2. No code issues, but after the initial addition of the RigidBody to the Cat, it would flip itself and the camera over. This was fixed by locking X and Z rotations. 

## Open-Source Assets

### W1

* Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727
* Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153

