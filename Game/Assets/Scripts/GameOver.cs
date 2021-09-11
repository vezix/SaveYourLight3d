using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy entered");
            GameManager.instance.mousemovement = false;
            GameManager.instance.GameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
