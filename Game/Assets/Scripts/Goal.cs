using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Goal : MonoBehaviour
{
    public GameObject text;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            Debug.Log("Player entered");
            if (GameManager.instance.key == GameManager.instance.keygoal)
            {
                TextMeshProUGUI textA = text.GetComponent<TextMeshProUGUI>();
                textA.SetText("Success");
                GameManager.instance.mousemovement = false;
                GameManager.instance.GameOverPanel.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

}
