using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next1 : MonoBehaviour
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
    yield return new WaitForSeconds (7f);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
 }
}
