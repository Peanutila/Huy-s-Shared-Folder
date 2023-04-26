using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool IsDetroyed;
    public GameObject mob;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }
    public void Spawn(){
        if (IsDetroyed){
            Debug.Log("Huy Chet roi");
            GameObject Cho_Huy = Instantiate(mob, transform.position, Quaternion.identity);
            Cho_Huy.tag = "target";
            Cho_Huy.transform.parent = transform;
            IsDetroyed = false;
        }
    }
}
