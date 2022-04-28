using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseManagement : MonoBehaviour
{
    public GameObject PauseMenu;

    public GameObject BoardGame;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Resume()
    {
        PauseMenu.SetActive(false);
        BoardGame.SetActive(true);
    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        BoardGame.SetActive(false);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
