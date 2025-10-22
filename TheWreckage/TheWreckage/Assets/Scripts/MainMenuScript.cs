using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    public Button startButton;
    void Start()
    {
        PauseGame();
        startButton.onClick.AddListener(TaskOnClick);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (mainMenu.activeInHierarchy)
            {
                PauseGame();
            } else if (!mainMenu.activeInHierarchy)
            {
                ContinueGame();
            }
        }
    }
    private void PauseGame()
    {
        Time.timeScale = 0;
        mainMenu.SetActive(true);
        //Disable scripts that still work while timescale is set to 0
    }
    private void ContinueGame()
    {
        Time.timeScale = 1;
        mainMenu.SetActive(false);
        //enable the scripts again
    }
    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        ContinueGame();
        Debug.Log("You have clicked the button!");
    }
}
