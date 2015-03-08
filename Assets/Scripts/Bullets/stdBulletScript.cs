using UnityEngine;
using System.Collections;

public class stdBulletScript : MonoBehaviour {

    public float speed;
    public int damage;

	void Start () {
        rigidbody.velocity = new Vector3(0.0f, speed, 0.0f);
	}
	
	void Update () {

    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    //destroys enemy and itself
    void OnTriggerEnter(Collider other) {
       
        if (other.tag == "Enemy") {
            other.gameObject.SendMessage("Hit",damage);
           // animateobject.animation.CrossFade("animationname");
            Destroy(gameObject);
        }


    }
}
