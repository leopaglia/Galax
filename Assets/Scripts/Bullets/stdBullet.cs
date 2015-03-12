using UnityEngine;
using System.Collections;
using templates;

public class stdBullet : BaseBullet {

    public override void InitialForce() {
        rigidbody.velocity = new Vector3(0.0f, speed, 0.0f);
    }

}
