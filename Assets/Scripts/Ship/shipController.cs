using UnityEngine;
using System.Collections;
using templates;

public class shipController : MonoBehaviour {

    public BaseWeapon[] weapons;

    void Start() {
        this.renderWeapons();
    }

    void renderWeapons() {

        //render
        GameObject ship = GameObject.Find("Ship");

        foreach (BaseWeapon weapon in weapons) 
            weapon.Render(ship);
   
        //set every weapon as child
        GameObject[] instancesArr = GameObject.FindGameObjectsWithTag("Weapon");

        for (int i = 0; i < instancesArr.Length; ++i) 
            instancesArr[i].gameObject.transform.SetParent(ship.transform);

    }
}

