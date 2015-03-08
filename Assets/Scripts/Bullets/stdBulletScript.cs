using UnityEngine;
using System.Collections;

public class stdBulletScript : MonoBehaviour {

    public float speed;
    public int damage;

	// Use this for initialization
	void Start () {
        rigidbody.velocity = new Vector3(0.0f, speed, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
       // Vector3 newPosition = transform.position;
       // newPosition.y += speed * Time.deltaTime;

       // transform.position = newPosition;
	}

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    //destroys enemy and itself
    void OnTriggerEnter(Collider other) {
       
        //other.Hit(this.damage);
        if (other.tag == "Enemy") {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }


    }
}
