using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour{
    
    [SerializeField] float turnSpeed = 300f;
    [SerializeField] float moveSpeed = 20f;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        float turnVar = turnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float moveVar = moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Rotate(0, 0, -turnVar);
        transform.Translate(0, moveVar, 0);
    }
}
