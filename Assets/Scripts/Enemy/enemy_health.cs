using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_health : MonoBehaviour
{
    Spawner spawn;
    private float health;
    public bool IsDetroyed = false;
    private void Start() {
        health = 100f; 
        spawn = GameObject.Find("Huy Spawner").GetComponent<Spawner>();
    }
    void Update()
    {
        if (health <= 0){
            spawn.IsDetroyed = true;
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision other) {
        if (other.transform.tag == "Bullet"){
            health = health - 20f;
        }
    }
}
