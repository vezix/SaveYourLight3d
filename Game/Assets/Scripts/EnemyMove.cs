using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    bool Seen = false;
    Transform player;
    Vector3 currPos;
    public float speed = 6;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        currPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void HitByRay()
    {
        Debug.Log("I was hit by a Ray");
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

    }


}
