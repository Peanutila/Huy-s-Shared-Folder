using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    [SerializeField]public bool approach;
    private float distance;
    
    private CharacterController character;
    void Start()
    {
        
        character = FindObjectOfType<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("target") != null){
            GameObject enemy;
            enemy = GameObject.FindWithTag("target");
            Nearby(enemy);
        } 
    }
    void Nearby(GameObject enemy){
        if (GameObject.FindWithTag("target") != null){
            distance = Vector3.Distance(character.transform.position, enemy.transform.position);
            if (distance <= 10){
                approach = true;
            } else {
                approach = false;
            }
        } else {
            approach = false;
        }
    }
    
}
