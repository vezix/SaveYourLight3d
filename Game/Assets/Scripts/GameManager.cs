using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    public GameObject GameOverPanel;
    public GameObject KeyNumberPanel;

    public bool mousemovement = true;
    public int keygoal;
    public int key;

    public GameObject Player;
    public float Percentage = 100;
    public float timeRemaining;


    [HideInInspector]
    public bool keynumchange = false;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }
    void Start()
    {
        key = 0;
        keygoal = 1;
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (keynumchange)
        {
            TextMeshProUGUI KeyText = KeyNumberPanel.GetComponent<TextMeshProUGUI>();
            KeyText.SetText("Current Keys :" + key);
            keynumchange = false;
        }
    }

    public void Restart()
    {
        key = 0;
        keygoal = 1;
        mousemovement = true;
        GameOverPanel.SetActive(false);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
