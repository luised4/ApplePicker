using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {
    public static float bottomY = -20f;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < bottomY)
        {
           // print("Apple");
            Destroy(this.gameObject);
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            apScript.AppleDestroyed();
        }
	}
}
