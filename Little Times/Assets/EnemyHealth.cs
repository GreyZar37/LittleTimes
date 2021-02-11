using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyMaxHealth;
    public float enemyCurrentHealth;

    public GameObject battleScene;

    // Start is called before the first frame update
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        print(enemyCurrentHealth);

        if (enemyCurrentHealth <= 0)
        {
            battleScene.SetActive(false);
            Destroy(gameObject);
        
        }


    }

    public void takeDamage(float damage)
    {
        enemyCurrentHealth -= damage;
    }

}
