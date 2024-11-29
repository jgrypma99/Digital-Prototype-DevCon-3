using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySlime : MonoBehaviour
{
    //score values
    int redValue = 125;
    int greenValue = 250;
    int blueValue = 500;

    //score manager
    GameObject managerObj;
    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        //on start set game manager
        managerObj = GameObject.Find("Game Manager");
        manager = managerObj.GetComponent<GameManager>();
    }
    

    //upon colliding with a gameobject with the same tag as the game object this scrip is attached to
    //destroy said gameobject and add the corresponding points to the total score
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(gameObject.tag))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            if (collision.gameObject.CompareTag("Red Slime"))
            {
                manager.totalScore = manager.totalScore + redValue;
                Debug.Log(manager.totalScore);
            }
            if (collision.gameObject.CompareTag("Green Slime"))
            {
                manager.totalScore = manager.totalScore + greenValue;
                Debug.Log(manager.totalScore);
            }
            if (collision.gameObject.CompareTag("Blue Slime"))
            {
                manager.totalScore = manager.totalScore + blueValue;
                Debug.Log(manager.totalScore);
            }
        }
    }
}
