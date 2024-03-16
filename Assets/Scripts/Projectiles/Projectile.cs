using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void FixedUpdate() {
        transform.position += transform.right * 5 * Time.fixedDeltaTime;
    }
}
