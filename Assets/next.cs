using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{

        private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("Main menu");
        }
    }
    void Start()
    {
        StartCoroutine(Next());
    }


 IEnumerator Next ()
 {
    yield return new WaitForSeconds (36f);
    SceneManager.LoadScene("Main menu");
 }
}
