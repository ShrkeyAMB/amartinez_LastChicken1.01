using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;



    private void Update()
    {
        enemy.SetDestination(player.position);
    }
}
