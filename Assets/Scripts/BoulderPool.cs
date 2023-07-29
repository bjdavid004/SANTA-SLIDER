using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderPool : MonoBehaviour
{
    [SerializeField] private IceBoulders m_IceBoulder;
    [SerializeField] private GiftBoulders m_GiftBoulder;

    void Start()
    {
        InvokeRepeating("SpawnIceBoulders", 2.0f, 2.0f);
        InvokeRepeating("SpawnGiftBoulders", 2.0f, 5.0f);
    }

    private void SpawnIceBoulders()
    {
        IceBoulders tempIceBoulders = Instantiate(m_IceBoulder);
        tempIceBoulders.Init(transform);
    }

    private void SpawnGiftBoulders()
    {
        GiftBoulders tempGiftBoulders = Instantiate(m_GiftBoulder);
        tempGiftBoulders.Init(transform);
    }
}
