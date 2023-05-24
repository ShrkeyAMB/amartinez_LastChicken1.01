using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundEffects : MonoBehaviour
{
    public AudioSource src;
    public AudioClip chickenDamaged;

    public PlayerHealth playerHealth;
    public int damaged;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            src.clip = chickenDamaged;
            src.Play();
        }
    }
}
