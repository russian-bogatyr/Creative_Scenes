using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour
{

    [SerializeField] Transform target;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(target);
    }
}
