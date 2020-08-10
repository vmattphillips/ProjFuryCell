using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void LateUpdate()
    {
        // Vector3 desiredPos = target.position + offset; // Get pos that you want the camera to go to for the frame
        // transform.position = desiredPos; // Sets new position
        // transform.LookAt(target);

        Vector3 setPosition = transform.position; // + offset;
        setPosition.x = target.transform.position.x; // + offset.x;
        //setPosition.y = offset.y;
        //setPosition.z = offset.z;
        transform.position = setPosition;

        //transform.LookAt(target);
    
    }
}