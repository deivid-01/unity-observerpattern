using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Range(0,10)]
    public float speed;
    void Update()
    {
        this.transform.position = this.transform.position +( Vector3.forward *Input.GetAxis("Vertical")+Vector3.right*Input.GetAxis("Horizontal"))*speed * Time.deltaTime;//Delta time es 1/FPS
    }
}
