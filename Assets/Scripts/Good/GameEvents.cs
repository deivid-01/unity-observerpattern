using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    //Subject
    #region Singlenton
    public static GameEvents Instance;

    private void Awake () => Instance = this;

    #endregion

    public event Action <int> OnDoorTriggerEnter;
    public event Action <int> OnDoorTriggerExit;

    public void DoorTriggerEnter ( int id ) => OnDoorTriggerEnter?.Invoke ( id );
    public void DoorTriggerExit ( int id ) => OnDoorTriggerExit?.Invoke ( id );

}
