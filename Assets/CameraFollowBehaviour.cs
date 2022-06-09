using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBehaviour : MonoBehaviour
{
    public GameObject playerObject;
  
    public Joystick cameraLookJoystick;
  
    // Update is called once per frame
    void Update()
    {
        transform.position = playerObject.transform.position;
        CameraLookToJoystickInput();    
    }

    public void CameraLookToJoystickInput()
    {
        transform.rotation =  Quaternion.Euler(new Vector3(transform.rotation.x, (cameraLookJoystick.Horizontal+cameraLookJoystick.Vertical)*180, transform.rotation.z));
    }
}
