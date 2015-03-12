using UnityEngine;
using System.Collections;

namespace templates {

    public abstract class BaseBullet : MonoBehaviour {

        public int damage;
        public float speed;

        abstract public void InitialForce();

        void Start() {
            this.InitialForce();
        }

        void OnBecameInvisible() {
            Destroy(gameObject);
        }

        void OnTriggerEnter(Collider other) {
            if (other.tag == "Enemy") {
                other.gameObject.SendMessage("Hit", damage);
                // animateobject.animation.CrossFade("animationname");
                Destroy(gameObject);
            }
        }

    }

}
