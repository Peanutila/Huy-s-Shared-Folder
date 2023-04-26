using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chasing : MonoBehaviour
{
    private GameObject mainCam;
    public NavMeshAgent enemy;
    private Transform target; 
    private int speed = 10;
    void Start()
    {
        mainCam = GameObject.Find("Body");
        enemy = GetComponent<NavMeshAgent>();
        target = GameObject.Find("FPS").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - mainCam.transform.position,Vector3.up);
        enemy.SetDestination(target.position);
        if (Vector3.Distance(target.position, transform.position) < 2){
            enemy.speed = 0;
        } else {
            enemy.speed = 5;
        }
    }
    
}
