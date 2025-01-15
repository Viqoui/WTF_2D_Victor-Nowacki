using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next2 : MonoBehaviour
{

        private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    void Start()
    {
        StartCoroutine(Next());
    }


 IEnumerator Next ()
 {
    yield return new WaitForSeconds (13f);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 }
}
