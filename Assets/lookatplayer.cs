using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatplayer : MonoBehaviour
{
    // Start is called before the first frame update
    Transform cameratransform;
    void Start()
    {
        cameratransform = Camera.main.transform; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cameratransform);
    }
}
