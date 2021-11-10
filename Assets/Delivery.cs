using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour {

    bool hasPackage = false;
    float destroyDelay = 0.1f;
    
    Color32 hasPackageColor = new Color(1, 0.8f, 0.5f, 1);
    Color32 noPackageColor = new Color(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();    
        spriteRenderer.color = noPackageColor;
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage){
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);

            spriteRenderer.color = hasPackageColor;
        }

        if (other.tag == "Delivery Point" && hasPackage){
            hasPackage = false;

            spriteRenderer.color = noPackageColor;
        }
    }
}
