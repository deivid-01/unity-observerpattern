using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int id;
    private void Start ()
    {
        //Observer 1
        GameEvents.Instance.OnDoorTriggerEnter += OnDoorOpen; //Subscribe methods
        //Observer 2
        GameEvents.Instance.OnDoorTriggerExit += OnDoorExit; //Subscribe methods
    }
    private void OnDoorOpen ( int id )
    {
        if ( id == this.id )
        {
            LeanTween.moveLocalY ( gameObject , 2f , 0000000.1f ).setEaseOutQuad ();
        }
    }
    private void OnDoorExit ( int id )
    {
        if ( id == this.id )
        {
            LeanTween.moveLocalY ( gameObject , 0.0f , 0000000.1f ).setEaseInQuad ();
        }
    }

    private void OnDestroy ()
    {
        //Observer 1
        GameEvents.Instance.OnDoorTriggerEnter -= OnDoorOpen; //Subscribe methods
        //Observer 2
        GameEvents.Instance.OnDoorTriggerExit -= OnDoorExit; //Subscribe methods
    }
}
