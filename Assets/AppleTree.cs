using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Set in Inspector")]
    //Prefab for instatiating apples
    public GameObject applePrefab;
    //speed at which the AppeTree moves
    public float speed = 1f;
    //Distance where  AppleTree turns around
    public float leftAndRightEdge = 10f;
    //Chance that the appleTree will change directions
    public float chanceToChangeDirections = 0.1f;
    //Rate at which apple will be instantiated
    public float secondsBetweeenAppleDrops = 1f;
	// Use this for initialization
	void Start () {
        //droping apple every second
        Invoke("DropApple",2f);
	}
	
    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweeenAppleDrops);
    }
	// Update is called once per frame
	void Update () {
        //Basic Movement 
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Changing direcctions
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);//move right
        }else if (pos.x > leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);//move left
        }else if (Random.value < chanceToChangeDirections)
        {
            speed *= 1; //Change directions
        }
	}
}
