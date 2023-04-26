using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    
    Radar radar;
    public TextMeshProUGUI element;
    Vector3 offset = new Vector3(0,2,0);
    Transform unit;
    Transform mainCam;
    
    
    private string TextValue;    
    void Start()
    {
        
        if (GameObject.FindWithTag("target") != null){
            unit = GameObject.FindWithTag("target").transform;
        }
        mainCam = Camera.main.transform;

        radar = GameObject.Find("Sensor").GetComponent<Radar>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - mainCam.position);
        if (unit != null){
            transform.position = unit.position + offset;
        }
        Enemy();
    }
    public void Enemy(){
        
        if (radar.approach == false){
            TextValue = "Chó huy dell gần bạn";
        } else {
            TextValue = "Chó huy đang gần bạn";
        }
        element.text = TextValue; 
    }
}
