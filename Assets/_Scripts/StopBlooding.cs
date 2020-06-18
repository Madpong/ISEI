using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBlooding : MonoBehaviour
{
    public float bloodTime;
    void Update()
    {
        bloodTime -= Time.deltaTime;

        if (bloodTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
