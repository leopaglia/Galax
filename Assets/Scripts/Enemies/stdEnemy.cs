using UnityEngine;
using System.Collections;

public class stdEnemy : MonoBehaviour {

    public int hp;
    public float speed;
    public float dropChance;
    public GameObject drop;

    private bool isQuitting;

	void Start () {
	
	}
	
	void Update () {
        
        if (hp <= 0) {
            Destroy(gameObject);
        //    animation.CrossFade("Destroy");
        }

	}

    void Hit(int damage) {
        this.hp -= damage;
    }

    void OnApplicationQuit() {
        isQuitting = true;
    }

    void OnDestroy() {

        //fix para edit mode
        if (!isQuitting) {
            
            int random = Random.Range(0, 100);
       
            //si esta en el rango de drop
            if (random <= dropChance) {
                Instantiate(drop, transform.position, transform.rotation);
            }

        }

    }
}
