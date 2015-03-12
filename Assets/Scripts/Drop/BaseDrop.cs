using UnityEngine;
using System.Collections;

namespace templates {

    public abstract class BaseDrop : MonoBehaviour {
        public int buffPower;
        public string buffMethodName;

        void OnTriggerEnter(Collider other) {
            if (other.tag == "Player" || other.tag == "Weapon") {
                GameObject.Find("Ship").SendMessage(buffMethodName, buffPower);
                Destroy(gameObject);
            }
        }

        void OnBecameInvisible() {
            Destroy(gameObject);
        }
    }

}