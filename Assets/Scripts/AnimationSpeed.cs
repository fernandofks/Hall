using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeed : MonoBehaviour
{
    GameObject CubeStop;
    Animation anim;
    void Start()
    {
        CubeStop = GameObject.Find("CubeStop");
        anim = CubeStop.GetComponent<Animation>();
        StartCoroutine(SelfDestruct());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SelfDestruct()
    {

     anim.SetFloat("speedMultiplier", 0);

    }
}
