using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    private Plane plane;
    public TextMeshProUGUI gameOverText;
    private float zRange = 16;
    public GameObject[] Bombs;
    public Button resetGame;
    public bool gameOverController = true;
    // Start is called before the first frame update
    void Start()
    {
        plane = GameObject.Find("Plane").GetComponent<Plane>();
        StartGame(2);
    }

    // Update is called once per frame
    void Update()
    {
        if (plane.heathy_ < 0)
        {
            GameOver();
        }
    }
    void SpawnBombs()
    {
        if (gameOverController)
        {
            float z_Range = Random.Range(-zRange, zRange);
            int bomIndex = Random.Range(0, Bombs.Length);
            Vector3 spawnPos = new Vector3(0, 18, z_Range);
            Instantiate(Bombs[bomIndex], spawnPos, Bombs[bomIndex].transform.rotation);
        }
    }
    public void StartGame(int difc)
    {
        InvokeRepeating("SpawnBombs", 2, difc);
        gameOverText.gameObject.SetActive(false);
        resetGame.gameObject.SetActive(false);

    }
    void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        resetGame.gameObject.SetActive(true);
        gameOverController = false;
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    
}
