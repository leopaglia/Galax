using UnityEngine;
using System.Collections;
using templates;
using helpers;

public class stdEnemy : BaseEnemy {

    public GameObject[] possibleDrops;
    public float BigDropRate;
    public float stdDropRate;

    void Start() {

        //-- Config drop rate -- sum <= 1
        float[] dropChances = {stdDropRate, BigDropRate};
        
        //-- Instances array (DropGameObject, DropRate)
        dropArray = new ObjAndChance[possibleDrops.Length];

        for (int i = 0; i < possibleDrops.Length; i++) {
            dropArray[i] = new ObjAndChance(possibleDrops[i], dropChances[i]);
        }
    }

   override public void Hit(int damage) {
        this.hp -= damage;
    }
}
