using UnityEngine;
using System.Collections;
using templates;


public class sideWeapon : BaseWeapon {

    public GameObject bullet;
    private Vector3 distToShip = new Vector3(0.8f, 0.0f, 0.0f);

    override public void Render(GameObject ship) {

        Instantiate(this, ship.transform.position - distToShip, ship.transform.rotation);
        Instantiate(this, ship.transform.position + distToShip, ship.transform.rotation);

        distToShip += new Vector3(0.5f, 0.0f, 0.0f);
    }

    override public void Shoot() {
        Instantiate(bullet, transform.position, transform.rotation);
    }

}
