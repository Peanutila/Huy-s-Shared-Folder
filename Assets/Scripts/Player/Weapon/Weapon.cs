using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public bool IsClicked = false;
    public GameObject bullet;
    void Start()
    {
    }
    void Update(){
        
        if (IsClicked == true){
            GameObject Spawn_Bullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Spawn_Bullet.GetComponent<Rigidbody>().velocity = transform.forward * 100;
            Spawn_Bullet.tag = "Bullet";
            Spawn_Bullet.transform.parent = transform;
            Debug.Log("SHOOT");
            IsClicked = false;

        }
        
        
    }
    // Update is called once per frame
    void OnCollisionEnter(Collision other) {
        Destroy(GameObject.Find("Bullet(Clone)").transform);
    }
    public void Spawn(){
        IsClicked = true;
    }
}
