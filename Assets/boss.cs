using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class boss : MonoBehaviour
{
 private const float V = 0f;

    // Start is called before the first frame update
    public float health = 4f;
    public Slider healthbar;
    public AudioClip death;
    
    public GameObject DeathEffect;

            void Death()
    {

        StartCoroutine(enumerator());
        Instantiate(DeathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
    IEnumerator enumerator()
    {
        yield return new WaitForSeconds(1f);
 }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = health;
        if (health <= 0)
        {
            Death();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
            
        
    }
     void OnCollisionEnter2D(Collision2D coll)
 {
    if(coll.relativeVelocity.magnitude > health)
        {
            health--;
        }

}


}
    