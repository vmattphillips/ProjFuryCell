using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desiredPos = target.position + offset; // Get pos that you want the camera to go to for the frame
        // Gets points between curr pos and desried pos, sets new pos to another position along that line.
        // smoothSpeed = 1 means it moves the entire distance in 1 frame, 
        // smoothSpeed = 0.5 means we move to the halfwaypoint between current pos and desiredPos, and etc
        //Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        // **Smoothing disabled, causes stuttering?**
        transform.position = desiredPos; // Sets new position
        transform.LookAt(target);
    
    }
}