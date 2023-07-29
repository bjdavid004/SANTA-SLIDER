using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowydriftscript : MonoBehaviour
{
    public GameObject arcadescript;

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            //do things
            Debug.Log("Enable drift");
            arcadescript.GetComponent<ArcadeKart>().IsDrifting = true;
        }
       

    }
    private void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            //do things
            Debug.Log("disable drift");
            arcadescript.GetComponent<ArcadeKart>().IsDrifting = false;
        }
    }
}
