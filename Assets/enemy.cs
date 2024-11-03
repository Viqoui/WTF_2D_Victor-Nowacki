using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject DeathEffect;
    public float health = 4f;
    public static int EnemiesAlive =0;
    void Start ()
    {
        EnemiesAlive++;
    }
    void OnCollisionEnter2D (Collision2D colInfo)
    {
        if(colInfo.relativeVelocity.magnitude > health)
        {
            Die();
        }
    }
    void Die()
    {
        Instantiate(DeathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
           EnemiesAlive--;
        if (EnemiesAlive <=0)
            Debug.Log("Level won!");
    }

    }

