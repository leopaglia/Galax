using UnityEngine;
using System.Collections;
using helpers;

namespace templates {

    public abstract class BaseEnemy : MonoBehaviour {

        public int hp;
        public ObjAndChance[] dropArray;

        abstract public void Hit(int damage);

        void OnDestroy() {

            if (dropArray.Length == 0)
                return;

            Probabilistic prob = new Probabilistic();
            GameObject drop = prob.GetObjFromChancesArray(dropArray);
                
            if(drop != null)
                Instantiate(drop, transform.position, transform.rotation);

        }

        void Update() {
            if (hp <= 0) 
                Destroy(gameObject);
        }   

    }
}
