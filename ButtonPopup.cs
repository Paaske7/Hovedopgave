using UnityEngine;
using System.Collections;
using Vuforia;
using System;



[RequireComponent(typeof(AudioSource))]
public class ButtonPopup : MonoBehaviour, ITrackableEventHandler
{
    public AudioClip jeer;
    public AudioClip laugther;
    public AudioClip taunt;

    AudioSource audio;

    private TrackableBehaviour mTrackableBehaviour;

    private bool mShowGUIButton = false;
    private Rect mButtonRect = new Rect(50, 50, 120, 60);
    //SpeechSynthesizer synthesizer = new SpeechSynthesizer();
    //synthesizer.Volume = 100;  // 0...100
    //        synthesizer.Rate = -2;     // -10...10
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();

        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
            //Console.Beep();
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            mShowGUIButton = true;
            //synthesizer.Speak("six of spades");
            audio.clip = laugther;
            audio.Play();

        }
        else
        {
            //synthesizer.Speak("nix of fades");
            mShowGUIButton = false;
            //audioData.Play(1);
            audio.clip = jeer;
            audio.Play();

        }
    }

    void OnGUI()
    {
        if (mShowGUIButton)
        {
            // draw the GUI button
            if (GUI.Button(mButtonRect, "Hello"))
            {
                //synthesizer.Speak("bop");
                // do something on button click 
                audio.clip = taunt;
                audio.Play();
            }
        }
    }
}