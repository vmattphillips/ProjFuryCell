  
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed, jumpSpeed;
    private float distToGround;
    private Rigidbody rb;
    private Collider col;

    //public GameObject hitbox;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        distToGround = col.bounds.extents.y;
    }

    void Start()
    {
        rb.freezeRotation = true;
        //hitbox.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetMovementInputs();
        
    }

    void GetMovementInputs()
    {
        //  Reading Movement Value
        float LR_Movement = 0f;
        float UpDwn_Movement = 0f;

        if (Input.GetKey(KeyCode.A))
            LR_Movement = -1f;
        if (Input.GetKey(KeyCode.D))
            LR_Movement = 1f;
        if (Input.GetKey(KeyCode.W))
            UpDwn_Movement = 1f;
        if (Input.GetKey(KeyCode.S))
            UpDwn_Movement = -1f;
        if(Input.GetKeyDown(KeyCode.Space))
            Jump();
        
        // Move Player
        Vector3 currPos = transform.position;
        currPos.x += LR_Movement * speed * Time.deltaTime;
        currPos.z += UpDwn_Movement * speed * Time.deltaTime;
        
        transform.position = currPos;
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
    }

    void Jump()
    {
        if(IsGrounded())
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode.Impulse);
        }
    }

    void Attack()
    {
        // Debug.Log("LeftClick");
        // hitbox.SetActive(true);
        // StartCoroutine(CoroutineAction(5));
        // hitbox.SetActive(false);
    }



    //public IEnumerator CoroutineAction(int frames)
    //{
        // do some actions here
        // Debug.Log("Starting Coroutine");  
        // yield return new WaitFor.Frames(frames); // wait for X frames
        // Debug.Log("Ending Coroutine");
    //}

}

public static class WaitFor
{
    public static IEnumerator Frames(int frameCount)
    {
        if (frameCount <= 0)
        {
            throw new ArgumentOutOfRangeException("frameCount", "Cannot wait for less that 1 frame");
        }

        while (frameCount > 0)
        {
            frameCount--;
            yield return null;
        }
    }
}