using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_Collide: MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        if (other.transform.tag == "Bullet"){
            Destroy(other.gameObject);
        }
    }
}
