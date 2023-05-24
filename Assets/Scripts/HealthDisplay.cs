using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public Sprite feather;
    public Image[] feathers;

    public PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health = playerHealth.currentHealth;
        maxHealth = playerHealth.currentHealth;

        for(int i = 0; i<feathers.Length; i++)
        {
            if( i < health)
            {
                feathers[i].sprite = feather;
            }

            if (i < maxHealth)
            {
                feathers[i].enabled = true;
            }
            else feathers[i].enabled = false;
        }
    }
}
