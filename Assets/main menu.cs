using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
   public Animator transistionAnim;

 public void PlayGame()
 {
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
