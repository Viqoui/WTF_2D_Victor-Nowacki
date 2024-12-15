using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{


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
