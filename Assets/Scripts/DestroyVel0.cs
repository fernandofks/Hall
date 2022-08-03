using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVel0 : MonoBehaviour
{
    // GameObject CubeStop;
    // GameObject CubeStop1;
    // GameObject CubeStop2;
    // GameObject CubeSlow;
    // GameObject CubeSlow1;
    // GameObject CubeSlow2;
    // GameObject CubeFast;
    // GameObject CubeFast1;
    // GameObject CubeFast2;
    // private int Time = 5;
    // Start is called before the first frame update
    void Start()
    {
    // CubeStop = GameObject.Find("CubeStop");
    // CubeStop1 = GameObject.Find("CubeStop1");
    // CubeStop2 = GameObject.Find("CubeStop2");
    // CubeSlow = GameObject.Find("CubeSlow");
    // CubeSlow1 = GameObject.Find("CubeSlow1");
    // CubeSlow2 = GameObject.Find("CubeSlow2");
    // CubeFast = GameObject.Find("CubeFast");
    // CubeFast1 = GameObject.Find("CubeFast1");
    // CubeFast2 = GameObject.Find("CubeFast2");

        StartCoroutine(SelfDestruct());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SelfDestruct()
    {
    // CubeStop.SetActive(true);
    // CubeStop1.SetActive(true);
    // CubeStop2.SetActive(true);
    // CubeSlow.SetActive(false);
    // CubeSlow1.SetActive(false);
    // CubeSlow2.SetActive(false);
    // CubeFast.SetActive(false);
    // CubeFast1.SetActive(false);
    // CubeFast2.SetActive(false);



     yield return new WaitForSeconds(5);
    // CubeStop.SetActive(false);
    // CubeStop1.SetActive(false);
    // CubeStop2.SetActive(false);
    }
}
