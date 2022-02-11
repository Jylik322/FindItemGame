using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Game Over UI")]
    public GameObject gameOverUI;

    [Space]
    [Header("Counting Time")]
    public float timeRemaining = 30;

    bool counting;
    Image image;
    private void Start()
    {
        counting = true;
        image = GetComponent<Image>();
    }

    void Update()
    {
        if (counting)
        {
            if (image.fillAmount > 0)
            {
                image.fillAmount -= 1.0f / timeRemaining * Time.deltaTime;

            }
            else
            {
                Debug.Log("end");
                gameOverUI.SetActive(true);
                counting = false;
            }
        }
    }
}