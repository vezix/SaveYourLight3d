using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered");
            GameManager.instance.key += 1;
            GameManager.instance.keynumchange = true;
            Destroy(this.gameObject);
            Debug.Log("key + 1");
        }
    }
}
