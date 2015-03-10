﻿using UnityEngine;
using System.Collections;

public class stdDrop : MonoBehaviour {

    public int speedBuff;

    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player" || other.tag == "Weapon"){ //horrible, cambiar
            GameObject.Find("Ship").SendMessage("Buff", speedBuff);
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
