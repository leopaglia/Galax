using UnityEngine;
using System.Collections;

public class shipController : MonoBehaviour {

    public GameObject[] weapons;

    private GameObject _instanceObj;
    private GameObject _instanceObj2;

    void Start() {
        this.renderWeapons();
    }


    void renderWeapons() {

        Vector3 vector = new Vector3(0.8f, 0.0f, 0.0f);

        foreach (GameObject weapon in weapons) {

            int id1 = Instantiate(weapon, transform.position - vector, transform.rotation).GetInstanceID();
            int id2 = Instantiate(weapon, transform.position + vector, transform.rotation).GetInstanceID();

            GameObject[] instancesArr = GameObject.FindGameObjectsWithTag("Weapon");

            for (int i = 0; i < instancesArr.Length; ++i) {

                if (instancesArr[i].GetInstanceID() == id1)
                    _instanceObj = instancesArr[i];

                if (instancesArr[i].GetInstanceID() == id2)
                    _instanceObj2 = instancesArr[i];
            }

            _instanceObj.gameObject.transform.parent = transform;
            _instanceObj2.gameObject.transform.parent = transform;

            vector += new Vector3(0.5f, 0.0f, 0.0f);
        }

    }
}

