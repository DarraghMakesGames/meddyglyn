using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject optionsMenu;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private GameObject contractLedger;

    public static float batchesMade = 0;
    public static float profit;
    public static int batchNumber = 1;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void PauseGame()
    {
        if (!mainMenu.activeSelf)
        {
            mainMenu.SetActive(true);
            restartButton.SetActive(true);
            gameUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            player.GetComponent<PlayerMovement>().enabled = false;
            Time.timeScale = 0;

        }

        else if (mainMenu.activeSelf || optionsMenu.activeSelf)
        {
            Time.timeScale = 1f;
            mainMenu.SetActive(false);
            optionsMenu.SetActive(false);
            gameUI.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            player.GetComponent<PlayerMovement>().enabled = true;
        }
    }

    public void UnPause()
    {
        Time.timeScale = 1f;
        gameUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        player.GetComponent<PlayerMovement>().enabled = true;
    }

    public void ToggleContractLedger()
    {
        if (!contractLedger.activeSelf)
        {
            contractLedger.SetActive(true);
            gameUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            player.GetComponent<PlayerMovement>().enabled = false;
            Time.timeScale = 0;

        }

        else if (contractLedger.activeSelf)
        {
            Time.timeScale = 1f;
            contractLedger.SetActive(false);
            gameUI.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            player.GetComponent<PlayerMovement>().enabled = true;
        }
    }

    public void Quit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LoadingScene");
    }

}
