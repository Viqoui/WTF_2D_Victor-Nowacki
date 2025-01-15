using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    float currentTime;
    float startingTime = 30f;
    [SerializeField] TextMeshProUGUI countdownText;
    void Start()
    {
        currentTime  = startingTime;
    }
    void Update()
    {
                if (currentTime <= 0f)
        {
            SceneManager.LoadScene("cutscene 3");
        }

        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");



    }

}
