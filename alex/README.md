# Alexandra Pablo

**Project name:** UR Camera Project
**Advisor:** Doga Ozgulbas
**Email:** apablo@anl.gov

## Project description

Utilizing 3D camera with UR5 robot to pick and place objects.

## Diarygit status

### 06/08 

-Finish most of training
-Finish CADing for robot
-Printing prototype today

### 06/14
Powerpoint:

### 07/18
Steps for Wall-E's process
1. Stream the camera
2. Look for specified object through object detection
3. Obtain thee 3D coordinates of the object from the camera
4. Move the gripper to center the frame to the center of the object
5. Move to the location above the object
6. Rotate the gripper downwards
7. Center the object in fram again if the object is not in
   line with the gripper
9. Rotate the gripper along the z axis from calculated angle so
   that the gripper can pick up the object**
10. Move downwards and close to pick up object
11. Pick up the object back to the location above to the object
12. Rotate the gripper around to show that it can move it around, wave it
13. Put it over a saved location, indicating the place that shows
    where to store the object
15. Drop down and open the gripper to drop the object

** In order to do step 8, we can obtain the best angle by keep rotating 
the camera in a loop to obtain the smallest area of the boundary box. 
The computer can rotate the orientation of the camera instead of 
rotating the gripper itself so that the process is more efficient

