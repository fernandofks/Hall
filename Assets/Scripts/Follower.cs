using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] GameObject hasToFollow;

    void Update()
    {
        transform.position = hasToFollow.transform.position;
        transform.rotation = hasToFollow.transform.rotation;
    }
}
