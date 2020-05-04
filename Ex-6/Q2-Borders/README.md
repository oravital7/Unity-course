# Changes

Added & edited 3 new scenes per section (3d-shield, 3d-shield-nolimit, 3d-shield-circle-limit)

Q1:

Added an object that displays the wood frame and Box Collider 2D componnet that any object with rigidbody 2d and "Player" tag cannot go through by unity physical rules.

-![](https://media.giphy.com/media/Pn1bXBRAsdDZ4L94bE/giphy.gif)

Q2:

Now every object that exits the game frame is totaly destroyed.
Based on the previous section, we can tell when an object is touching a frame and so we can delete it.

- [cleanObjects script](https://github.com/oravital7/Unity-course/blob/master/Ex-6/Q2-Borders/Assets/cleanObjects.cs)

-![](https://media.giphy.com/media/cOL92M4cdu5myb4jMO/giphy.gif)

Q3:

Now player can move in a circular way.
When touching the edge we move the spaceship location opposite from the location it's was.

- [CirclularMovement script](https://github.com/oravital7/Unity-course/blob/master/Ex-6/Q2-Borders/Assets/CirclularMovement.cs)

-![](https://media.giphy.com/media/KEeYAKW2lyFJwlYV16/giphy.gif)
