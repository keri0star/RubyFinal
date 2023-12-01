using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpeed : MonoBehaviour
{
    public AudioClip collectedClip;
    public ParticleSystem SpeedCollectibleEffect;

    void Start()
    {
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController1 controller = other.GetComponent<RubyController1>();

        if (controller != null)
        {
                controller.SpeedPickup(3);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
        }
    }
}