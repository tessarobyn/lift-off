using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(10, 25, 5) * Time.deltaTime);
    }
}
