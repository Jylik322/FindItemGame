using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StarsController : MonoBehaviour
{
    [Header("Stars UI")]
    [SerializeField] Image[] stars;

    [Header("Coins Manager Reference")]
    [SerializeField] CoinsManager coinsManager;

    [Space]
    [Header("Full Star Sprite:")]
    [SerializeField] Sprite fullStar;
    void Start()
    {
        switch (coinsManager.Coins)
        {
            case 0:
                break;
            case 1:
                stars[0].sprite = fullStar;
                break;
            case 2:
                stars[0].sprite = fullStar;
                stars[1].sprite = fullStar;
                break;
            case 3:    
                stars[0].sprite = fullStar;
                stars[1].sprite = fullStar;
                stars[2].sprite = fullStar;
                break;
        }
    }

    // Update is called once per frame
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
