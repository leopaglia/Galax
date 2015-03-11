using UnityEngine;
using System.Collections;
using templates;

namespace helpers {

    public class ObjAndChance{
        
        public GameObject obj{get;set;}
        public float chance{get;set;}

        public ObjAndChance(GameObject _obj, float _chance) {
            obj = _obj;
            chance = _chance;
        }

    }

    public class Probabilistic {

        public GameObject GetObjFromChancesArray(ObjAndChance[] array) {

            float random = Random.Range(0.0f, 1.0f);
            float chance = 0.0f;
            float chanceAnt = 0.0f;

            foreach (ObjAndChance item in array) {

                chance += item.chance;

                if (chanceAnt < random && random < chance) 
                    return item.obj;

                chanceAnt += chance;
            }

            if (chance < 1) return null;
           
            else Debug.LogError("La suma de las chances supera 100%");
            return null;
        }

    }

}
