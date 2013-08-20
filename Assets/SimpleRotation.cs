using UnityEngine;
using System.Collections;

public class SimpleRotation : MonoBehaviour
{
    float spin;

    void Awake ()
    {
        spin = Random.Range (-90.0f, 90.0f);
    }

    void Update ()
    {
        transform.localRotation = Quaternion.AngleAxis (spin * Time.deltaTime, Vector3.up) * transform.localRotation;
    }
}
