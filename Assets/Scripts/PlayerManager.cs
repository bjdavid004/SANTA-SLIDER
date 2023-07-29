using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Animator m_Anim;
    GameFlowManager manager;
    public int maxHealth;
    private int currentHealth;
    public static
    ObjectiveToast toast;
    bool IsGameOver;

    private void Start()
    {
        IceBoulders.OnPlayerHit += OnPlayerHit;
        currentHealth = maxHealth;
        StartCoroutine(FindToast());
    }

    private void OnDestroy()
    {
        IceBoulders.OnPlayerHit -= OnPlayerHit;
    }

    private void OnPlayerHit()
    {
        if (IsGameOver) return;
        m_Anim.SetTrigger("Hit");
        currentHealth--;
        string message = currentHealth.ToString();
        toast.SetHealth(message);
        if(currentHealth <=0)
        {
            IsGameOver = true;
            manager.HealthOver();
        }
    }

    IEnumerator FindToast()
    {
        yield return new WaitForSeconds(2);
        toast = GameObject.FindObjectOfType<ObjectiveToast>();
        manager = GameObject.FindObjectOfType<GameFlowManager>();
        string message = currentHealth.ToString();
        toast.SetHealth(message);
    }
}
