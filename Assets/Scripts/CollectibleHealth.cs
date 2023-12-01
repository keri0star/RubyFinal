using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleHealth : MonoBehaviour
{
    public AudioClip collectedClip;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController1 controller = other.GetComponent<RubyController1>();

        if (controller != null)
        {
            if(controller.currentHealth < controller.maxHealth)
            {
                controller.ChangeHealth(10);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }
        }
    }
}
