using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenLog : MonoBehaviour
{
    public BuoyancyEffector2D buoyancyEffector;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        buoyancyEffector.flowMagnitude = 10f;
    }
}
