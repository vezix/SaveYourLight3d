using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMove : MonoBehaviour
{
    public Transform target=null;
    public Transform homePos=null;
    public float speed = 10f;
    bool moving = false;

    public string text;
    public void OnHitEnter()
    {
        moving = true;
        Debug.Log("On hit Enter " + text);
    }

    public void OnHitStay()
    {
        //Debug.Log("On hit Stay " + text);
    }

    public void OnHitExit()
    {
        Debug.Log("On hit Exit " + text);
        moving = false;
    }

    private void Update()
    {
        if (moving == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        if (moving == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, homePos.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Enemy entered");
            GameManager.instance.mousemovement = false;
            GameManager.instance.GameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }


}
