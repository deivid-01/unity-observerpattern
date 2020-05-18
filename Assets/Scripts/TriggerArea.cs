using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter ( Collider other )
    {
        if ( other.name.Equals ( "Player" ) )
        {          
            GameEvents.Instance.DoorTriggerEnter (id);       
        }
    }

    private void OnTriggerExit ( Collider other )
    {
        if ( other.name.Equals ( "Player" ) )
        {
            GameEvents.Instance.DoorTriggerExit (id);
        }
    }
}

