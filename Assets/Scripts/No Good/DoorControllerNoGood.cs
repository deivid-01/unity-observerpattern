using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DoorControllerNoGood : MonoBehaviour
{
    public bool open;

    private void Start () => open = false;


    private void Update ()
    { 
        if ( open )
            OnDoorOpen ();
        else
            OnDoorExit ();
    }

    public  void OnDoorOpen ( ) => LeanTween.moveLocalY ( gameObject , 2f , 0000000.1f ).setEaseOutQuad ();
   
    public  void OnDoorExit (  ) => LeanTween.moveLocalY ( gameObject , 0.0f , 0000000.1f ).setEaseInQuad ();
    

    

}
