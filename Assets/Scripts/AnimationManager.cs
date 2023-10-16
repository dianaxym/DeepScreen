using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{

    public GameObject group1;
    public GameObject group2;
    public GameObject group3;

    private Animator[] animators1;
    private Animator[] animators2;
    private Animator[] animators3;
    void Start()
    {
        animators1 = group1.GetComponentsInChildren<Animator>();
        animators2 = group2.GetComponentsInChildren<Animator>();
        animators3 = group3.GetComponentsInChildren<Animator>();
    }

    
    void Update()
    {
     
    }
}
