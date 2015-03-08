using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public GameObject stdBullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space")) 
            Instantiate(stdBullet, transform.position, transform.rotation);
    }
}