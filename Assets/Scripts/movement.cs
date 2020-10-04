using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject robot;
    public GameObject arCamera;
    private Animator robotAnimator;
    private bool happy = false;

    void Start()
    {
        robotAnimator = robot.GetComponent<Animator>();
    }

    void Update()
    {
        float currentDist = Vector3.Distance(arCamera.transform.position, robot.transform.position);
        
        if (currentDist < 400 && !happy)
        {
            happy = true;
            robotAnimator.SetBool("normal", false);
            robotAnimator.SetBool("happy", true);
        }
        if(currentDist >= 400 && happy)
        {
            happy = false;
            robotAnimator.SetBool("happy", false);
            robotAnimator.SetBool("normal", true);
        }
    }
}
