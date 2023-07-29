using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GiftBoulders : IceBoulders
{
    public static Action OnGiftPickUp;

    public override void Start()
    {
        base.Start();
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            OnGiftPickUp?.Invoke();
        }
    }
}
