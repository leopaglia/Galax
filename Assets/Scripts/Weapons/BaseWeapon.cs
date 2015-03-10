using UnityEngine;
using System.Collections;

namespace templates {

    public abstract class BaseWeapon : MonoBehaviour {

        abstract public void Render( GameObject ship);

        abstract public void Shoot();

        void Update() { if (Input.GetKeyDown("space")) this.Shoot(); }

    }
}

