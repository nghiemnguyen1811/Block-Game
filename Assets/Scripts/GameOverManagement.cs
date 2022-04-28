using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverManagement : MonoBehaviour
{
    public GameObject BoardGame;
    // Start is called before the first frame update
    void Start()
    {
        BoardGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
