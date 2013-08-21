using UnityEngine;
using System.Collections;

public class SimpleRotation : MonoBehaviour
{
    public float spin;

    void Update ()
    {
        transform.localRotation = Quaternion.AngleAxis (spin * Time.deltaTime, Vector3.up) * transform.localRotation;
    }
}
