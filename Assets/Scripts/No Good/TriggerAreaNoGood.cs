using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAreaNoGood : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerEnter ( Collider other ) => door.GetComponent<DoorControllerNoGood>().open = true;

    private void OnTriggerExit ( Collider other ) => door.GetComponent<DoorControllerNoGood> ().open = false;

}

