using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAutomatic : MonoBehaviour
{
    public float time;
    private void Start()
    {
        Destroy(gameObject, time);
    }
}
