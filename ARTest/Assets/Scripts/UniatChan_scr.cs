using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class UniatChan_scr : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour trackable;

    void Start()
    {
        trackable = this.GetComponent<TrackableBehaviour>();
        if (trackable)
            trackable.RegisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status PreviousSta, TrackableBehaviour.Status NewSta)
    {
        if (NewSta == TrackableBehaviour.Status.DETECTED || NewSta == TrackableBehaviour.Status.TRACKED)
            Debug.Log("Ia estoy en la escena haha salu2");
        else
            Debug.Log("Ia me voy a dormir");
    }
}