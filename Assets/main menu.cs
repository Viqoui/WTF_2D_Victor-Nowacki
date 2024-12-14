using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
   public Animator transistionAnim;
    public IEnumerator Wait()
    {

            yield return new WaitForSeconds(100000);
    }

    public void PlayGame()
 {
   StartCoroutine(Wait());
    SceneManager.LoadScene("Level one");
      
 }


    public void Quit ()
 {
    Application.Quit();
    #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
  
 }
}
