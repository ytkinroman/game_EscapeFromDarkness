using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI gameVersionText;
    public TextMeshProUGUI gameTitleText;

    string gameVersion;
    string gameTitle;

    private void Start()
    {
        SetGameTitle();
        SetGameVersion();
    }

    private void Update()
    {
        
    }

    private void SetGameVersion()
    {
        gameVersion = Application.version;
        gameVersionText.text = "v. " + gameVersion;
    }

    private void SetGameTitle()
    {
        gameTitle = Application.productName;
        gameTitleText.text = gameTitle;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
