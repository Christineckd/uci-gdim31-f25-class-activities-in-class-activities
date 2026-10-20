# in-class-activities
## Devlogs
### W1
When the Camera of the Cat GameObject is moved off, the camera will no longer follow the Cat, it stays in place. This happens because GameObjects that are nested below another object in the hierarchy will move with that object.

[My W1 activity on Itch.io](https://clay-k-dale.itch.io/cat)

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
1. Because the rgb are all numbers from 0 to 1, they are all decimel numbers.
2. because _bounce is a whole number.
3. That line misses a semicolon.

### W3
A1.
1. the parameters will be a int and a boolean, the friendship level is a int, the knowSecret is a boolean. The return type is a string since the output is a text.
2. The parameter will be a float since it's numbers between 0 to 100. There is no output, the return type is void.
3. The parameter will be a float since we will be traking now much time it takes the player to hit the butten. the return type will be a bool, this can tell the player either they hit at the right time or not.
A2.
methods is the resepy of a dish, the class is the food that's made, the member variables are the ingredients.
A3.
The ball color gets lighter because every time when the ball collide and bounced higher and further, it increses the GetColorMultiplier. The value of RGB color for the ball, ballRenderer.color, will increace and approche 1, which is white.

### W4
1. What solution did you come up with for the collider activity, and why? Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?
We addrigidbody to the cat and the soccerBall since they will collide and need a physics simulations. The Goal don't need a Rigidbody because it only need to stay in the same place. We check Goal is Trigger because the ball need to get through the Goal to get poins.
2. IF your game did not work perfectly the first time you tested it, talk about what you had to fix.
I put an additionle .text after my timing variable, _time. I ifx it by remoing .text.
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 