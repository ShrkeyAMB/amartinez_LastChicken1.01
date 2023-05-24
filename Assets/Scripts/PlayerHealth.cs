using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 5;
    public ProjectileShooting shooting;
    public PlayerControllerIsometic movement;
    public IsometricAim aim;
    
    

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        
    }

   public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if(currentHealth < 1)
        {
            shooting.enabled = false;
            movement.enabled = false;
            aim.enabled = false;
        }
    }
}
