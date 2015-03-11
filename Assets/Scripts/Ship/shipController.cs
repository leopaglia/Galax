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
        GameObject[] instancesArray = GameObject.FindGameObjectsWithTag("Weapon");

        foreach (GameObject instance in instancesArray) {
            instance.gameObject.transform.SetParent(ship.transform);
        }

    }
}

