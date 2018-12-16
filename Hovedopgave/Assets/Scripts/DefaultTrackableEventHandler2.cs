using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DefaultTrackableEventHandler2 : MonoBehaviour, ITrackableEventHandler
{
    // Mikael Paaske
    // Vuforias egen kode hvor Mikael har tilføjet logik
    #region PROTECTED_MEMBER_VARIABLES
    protected TrackableBehaviour mTrackableBehaviour;

    public GameObject canvas;

    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;
    ShowData showData;
    private GameObject QRIcon;
    #endregion

    #region UNITY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        // Henter scriptet ShowData
        showData = gameObject.AddComponent<ShowData>();
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    #endregion

    #region PUBLIC_METHODS

    public void OnTrackableStateChanged(

        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
        }
        else
        {
            OnTrackingLost();
        }
    }

    #endregion

    #region PROTECTED_METHODS

    protected virtual void OnTrackingFound()
    {
        canvas.SetActive(true);

        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        foreach (var component in rendererComponents)
            component.enabled = true;

        foreach (var component in colliderComponents)
            component.enabled = true;

        foreach (var component in canvasComponents)
            component.enabled = true;
        
        if (GameObject.Find("ScanIcon") != null)
        {
            QRIcon = GameObject.Find("ScanIcon");
            QRIcon.SetActive(false);
        }
        // Kalder database udfra hvilken Image Target den finder i Vuforias database
        if (mTrackableBehaviour.TrackableName == "QRCode1")
        {
            showData.CallDatabaseQRCode1();
        }
        else if (mTrackableBehaviour.TrackableName == "QRCode2")
        {
            showData.CallDatabaseQRCode2();
        }
        else if (mTrackableBehaviour.TrackableName == "QRCode3")
        {
            showData.CallDatabaseQRCode3();
        }
        else if (mTrackableBehaviour.TrackableName == "QRCode4")
        {
            showData.CallDatabaseQRCode4();
        }
        else
        {
            Debug.Log("Kunne ikke finde navnet");
        }

    }
    protected virtual void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        foreach (var component in rendererComponents)
            component.enabled = false;

        foreach (var component in colliderComponents)
            component.enabled = false;

        foreach (var component in canvasComponents)
            component.enabled = false;
        canvas.SetActive(false);
        QRIcon.SetActive(true);
    }
        #endregion 
}
