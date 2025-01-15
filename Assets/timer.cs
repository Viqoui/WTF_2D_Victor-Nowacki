using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    float currentTime;
    float startingTime = 5f;
    [SerializeField] TextMeshProUGUI countdownText;
    void Start()
    {
        currentTime  = startingTime;
    }
    void Update()
    {
                if (currentTime <= 0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");



    }

}
