using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class UniatChan_scr : MonoBehaviour, ITrackableEventHandler
{
    TrackableBehaviour trackable;
    GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        trackable = this.GetComponent<TrackableBehaviour>();
        if (trackable)
            trackable.RegisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status PreviousSta, TrackableBehaviour.Status NewSta)
    {
        if (NewSta == TrackableBehaviour.Status.DETECTED || NewSta == TrackableBehaviour.Status.TRACKED)
        {
            gameManager.SetBJugador(true);
            Debug.Log("Ia estoy en la escena haha salu2");
        }
        else
        {
            gameManager.SetBJugador(false);
            Debug.Log("Ia me voy a dormir");
        }
    }
}