using UnityEngine;
using System.Collections;

public class stdDrop : MonoBehaviour {

    public int speedBuff;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            other.gameObject.SendMessage("Buff", speedBuff);
            Destroy(gameObject);
        }

    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
