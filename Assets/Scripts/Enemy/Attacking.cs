using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    Chasing Huy;
    private float time;
    Health_Bar Player;
    private float dist;
    void Start()
    {
        Huy = GetComponent<Chasing>();
        Player = GameObject.FindWithTag("Player").GetComponent<Health_Bar>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, GameObject.FindWithTag("Player").transform.position);
        if (Att_Con() == true){
            time = time + Time.deltaTime;
            if (time >= 1){
                Player.Player_Health = Player.Player_Health - 5;
                time = 0;
            }
        }
    }
    public bool Att_Con(){
        if (Huy.enemy.speed <= 1 && dist <= 2){
            return true;
        } else{
            return false;
        }
        
    }
}