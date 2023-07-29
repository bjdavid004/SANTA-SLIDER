using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Metadesc.CameraShake;
using System;

public class IceBoulders : MonoBehaviour
{
    public static Action OnPlayerHit;

    [SerializeField] protected Rigidbody m_Rigidbody;
    [SerializeField] protected float m_MinSpeed;
    [SerializeField] protected float m_MaxSpeed;
    private Vector3 m_DirectionToMove;
    public virtual void Start()
    {

    }

    public void Init(Transform releaser)
    {
        m_DirectionToMove = releaser.forward;
        transform.position = releaser.position;
    }

    public virtual void FixedUpdate()
    {
        m_Rigidbody.AddForce(m_DirectionToMove * UnityEngine.Random.Range(m_MinSpeed, m_MaxSpeed));
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            OnPlayerHit?.Invoke();
            ShakeManager.I.AddShake("Explosion");
            SantaAudioManager.instance.PlayHurtSound();
        }
    }
}
