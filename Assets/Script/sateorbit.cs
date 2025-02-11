using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sateorbit : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float degreesPerSecond = 45;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.right, degreesPerSecond * Time.deltaTime);
    }
}
