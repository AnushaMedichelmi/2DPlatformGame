using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public float destroyTimer;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(DestroyBridge(destroyTimer));
    }
    IEnumerator DestroyBridge(float time)
    {
       yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}

