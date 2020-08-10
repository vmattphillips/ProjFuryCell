using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldRules : MonoBehaviour
{

    public static int FrameRate = 60;
    public static float Gravity = 25f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = FrameRate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
