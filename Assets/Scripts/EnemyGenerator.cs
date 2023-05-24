using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy;
    public float xPos;
    public float zPos;
    public int enemyCount;

    private void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            xPos = Random.Range(-47, 47);
            zPos = Random.Range(-47, 47);
            Instantiate(Enemy, new Vector3(xPos, 1, zPos), Quaternion.identity);


            yield return new WaitForSeconds(10);
            enemyCount -= 1;
        }
    }
}
