using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftPicker : MonoBehaviour
{
    public GameObject[] allSlots;
    private int giftIndex;

    private void Start()
    {
        GiftBoulders.OnGiftPickUp += OnGiftPickup;
    }

    private void OnDestroy()
    {
        GiftBoulders.OnGiftPickUp -= OnGiftPickup;
    }

    public void OnGiftPickup()
    {
        allSlots[giftIndex].SetActive(true);
        giftIndex++;
    }
}
