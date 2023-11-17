using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Point1Controller : MonoBehaviour
{
    public PlayableDirector timelineBeforePoint1;
    public PlayableDirector timelinePoint1Help;
    public PlayableDirector timelinePoint1Run;
    public GameObject canvas;


    
    // Called by the button click signal in the Timeline
    public void OnRunClicked()
    {
        // Add any logic you need before playing the second timeline
        timelineBeforePoint1.Stop();
        canvas.SetActive(false);
        // Play the second timeline
        PlayRunTimeline();
    }

    public void OnHelpClicked()
    {
        // Add any logic you need before playing the second timeline
        timelineBeforePoint1.Stop();
        canvas.SetActive(false);
        // Play the second timeline
        PlayHelpTimeline();
    }

    void PlayHelpTimeline()
    {

        if (timelinePoint1Help != null)
        {
            // Play the second timeline
            timelinePoint1Help.Play();
        }
    }

    void PlayRunTimeline()
    {

        if (timelinePoint1Run != null)
        {
            // Play the second timeline
            timelinePoint1Run.Play();
        }
    }
}
