# Vector Maths for Games

A vector $v$ is a sequence of numbers, for example $(2,-3)$ could be seen as a 2D vector, and $(3,-1,4)$ as a 3D etc....

If we want to be as general as possible, we could say $v = (v_{0}, v_{1}, v_{2} , \cdots , v_{n-1})$ is a vector over $\mathbb{R}^{n}$  

For this course we are assuming that, unless otherwise specified, all vectors are 3D vectors, i.e.  $v = (x , y, z )$ where $x,y,z  \in \mathbb{R}$

## Vector Operations

### Vector Addition

Defn:
if $v_{1} = (x_{1}, y_{1}, z_{1})$ and $v_{2} = (x_{2}, y_{2}, z_{2})$ then

$v + u = (x_{1}, y_{1}, z_{1}) + (x_{2}, y_{2}, z_{2}) = (x_{1}+ x_{2}, y_{1}+y_{2},  z_{1}+z_{2})$

When we graph this, it gives rise to the Parallelogram Law

<img width="435" height="296" alt="image" src="https://github.com/user-attachments/assets/9256fbf6-8659-43be-a2ec-3f2c6aa603eb" />


### Vector Subtraction

Defn: similar to the addition except subtracting each corresponding element from each other.

This gives rise to the extreemly usefull $v$ to $u = u - v$

<img width="573" height="329" alt="image" src="https://github.com/user-attachments/assets/8cf1973e-5f83-4c4e-a6e2-c84b2655cc59" />

### Scalar Multiplication

Here Scalar represents a number or a non-vector, something like, 1,3.54, 0.1,-3.4

Defn:  $v = (x , y, z )$  then $\lambda v = \lambda (x , y, z ) = (\lambda x, \lambda y, \lambda z)$

This actually scales the vector by the scalar factor.


### Magnitude of a vector

Defn:
   For  $v = (x , y, z )$ then  $|v| = \sqrt{x^{2} + y^{2} + z^{2}}$

### Unit Vector

Defn: A unit vector is a vector with length 1.

Eg.  (1,0,0), (0,1,0) and (0,0,1) are all unit vectors. (These are actually called the orthonormal unit vectors in x,y,z)

To calculate the unit vector $u$ parallel to $v$ we just need to divide the vector $v$ by its own magnitude.

So $u = \frac{v}{|v|}$

Eg.  Find the unit vector parallel to the vector (-12,3,-4)

Soln:
$|v| = \sqrt{(-12)^{2} + 3^{2} + (-4)^{2}} = \sqrt{144 + 9 + 16} = \sqrt{169} = 13$

Hence $u = \frac{1}{13} (-12,3,-4) = (\frac{-12}{13}, \frac{3}{13}, \frac{-4}{13})$

## Vector Multiplication

### Scalar (Dot) Product of 2 vectors

Defn:

if $v_{1} = (x_{1}, y_{1}, z_{1})$ and $v_{2} = (x_{2}, y_{2}, z_{2})$ then

$v \cdot u =  x_{1}\times  x_{2} + y_{1}\times y_{2} +   z_{1} \times z_{2}$

This may also be calculated as

$v \cdot u = |v||u|\cos(\theta)$ where $\theta$ is the angle between the 2 vectors

<img width="242" height="258" alt="image" src="https://github.com/user-attachments/assets/9d043a04-b145-48ee-9db3-64d852449bbf" />

This is really usefull in games to determine whether a character is "facing" their target.  (For this example we are assuming that facing means within 90 degrees.

Example:

<img width="721" height="430" alt="image" src="https://github.com/user-attachments/assets/641d7b56-91e3-43ff-9464-e81e9ad3cdeb" />

$v_{1 to 2}$ = NPC1 to CPC2 = (1,3,4) - (3,2,6) = (-2, 1, -2)

$|v_{1 to 2}| = |(-2, 1, -2)| = \sqrt{ (-2)^{2} + 1^{2} + (-2)^{2} } = \sqrt{4 + 1 + 4} = 3$

$NPC1_{forward}$ is the unit vector parallel to (4,2,4)

$|(4,2,4)| = \sqrt{4^{2} + 2^2 + 4^2} = 6$

$NPC1_{forward} = \frac16 (4,2,4)$

NPC1 is facing NPC2 if NPC1 to NPC2 is in same direction as NPC1.forward.

So is (-2,1,-2) in the same direction as (4,2,4)

Only if the scalar dot product is greater than 0

$(-1,1,-2) \cdot (4,2,4) = -2 \times 4 + 1 \times 2 + -2 \times 4 = -14$  No

Is NPC2 facing NPC1?  We need to compare "NPC2 to NPC1" to NPC2 forward

Clearly NPC2 to NPC1 = -(NPC1 to NPC2) = -(-2,1,-2) = (2,-1,2)
NPC2.forward is parallel to (7,4,4)

Getting scalar dot product $(2,-1,2) \cdot (7,4,4) = 14 + (-4) + 8 = 18 >0$   Yes

NPC1 not facing NPC2
NPC2 is facing NPC1
Distance 3 < Max distance 4 

Ans NO 

<img width="744" height="556" alt="image" src="https://github.com/user-attachments/assets/61d90702-c3a6-45b0-8d47-540348cc3978" />

$v_{char to target} = (4,9,6) - (2,12,0) = (2, -3, 6) $

$|v_{char to target}| = |(2,-3,6)| = \sqrt{2^2+(-3)^2 + 6^2} = \sqrt{49} = 7$

The character forward is the unit vector parallell to (-2, 10, 25)

$|(-2, 10, 25)| = \sqrt{(-2)^2 + 10^2 + 25^2} = \sqrt{4 + 100 + 625} = \sqrt{729} = 27$

$v_{CharForward} = \frac1{27}(-2,10,25)$

Character is facing target if $v_{char to target}$ is in "same direction" (less than 90 degrees) as character forward.  
So the question is...

Is the angle between (2, -3, 6) and (-2, 10, 25) less than 90 degrees, or is the scalar dot product of the 2 vectors positive?

$(2,-3,6) \cdot (-2,10, 25) = 2 \times (-2) + (-3) \times 10 + 6 \times 25 = -4 + (-30) + 150 = 116 >0$

Yes character is facing the target.

A direction is usually a unit vector, so the direction should be the unit vector parallell to $v_{char to target}  = (2, -3, 6) $

We have already seen that this has magnitude 7, so the direction of the projectile shold be

$\frac17 (2, -3, 6) $

projectile.velocity = ProjectileSpeed * $\frac17 (2, -3, 6) $;


## Missile Lock, or calculating the actual angle between vectors

You can easily find the exact angle between two vectors using the dot product.

E.g.
Let $v = (6, 3, -2)$ and $u = (4,-12,3)$

We use the following formula

$v \cdot u = |v||u|\cos(\theta)$ where $\theta$ is the angle between the 2 vectors
