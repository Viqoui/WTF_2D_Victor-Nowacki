using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class alien_counter : MonoBehaviour
{
   
    public TextMeshProUGUI aliencountext;
    void Update()
    {
        int inactiveAliens = FindObjectsByType<SpriteRenderer>(FindObjectsInactive.Include, FindObjectsSortMode.None)
                                .Where(sr => sr.CompareTag("alien"))
                                .Where(sr => !sr.gameObject.activeInHierarchy)
                                .Count();
        aliencountext.text = $"Aliens left: {inactiveAliens}";
    }
}
