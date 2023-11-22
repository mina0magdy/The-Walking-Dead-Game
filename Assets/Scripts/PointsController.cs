using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PointsController : MonoBehaviour
{
    public PlayableDirector timelineBeforePoint1;
    public PlayableDirector timelinePoint1Help;
    public PlayableDirector timelinePoint1Run;
    public PlayableDirector timelineBeforePoint2;
    public PlayableDirector timelinePoint2Fight;
    public PlayableDirector timelinePoint2Run;
    public PlayableDirector timelinePoint2Kill;
    public PlayableDirector timelinePoint2NotKill;
    public GameObject canvas;
    public GameObject canvas1;
    public GameObject canvas2;



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
    public void OnRunAfterRunClicked()
    {
        // Add any logic you need before playing the second timeline
        timelineBeforePoint2.Stop();
        canvas1.SetActive(false);
        // Play the second timeline
        PlayRunafterRunTimeline();
    }

    public void OnFightClicked()
    {
        // Add any logic you need before playing the second timeline
        timelineBeforePoint2.Stop();
        canvas1.SetActive(false);
        // Play the second timeline
        PlayFightTimeline();
    }
    public void OnKillAfterHelpClicked()
    {
        // Add any logic you need before playing the second timeline
        timelinePoint1Help.Stop();
        canvas2.SetActive(false);
        // Play the second timeline
        PlayKillAfterHelpTimeline();
    }
    public void OnNotKillAfterHelpClicked()
    {
        // Add any logic you need before playing the second timeline
        timelinePoint1Help.Stop();
        canvas2.SetActive(false);
        // Play the second timeline
        PlayNotKillafterHelpTimeline();
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
    void PlayFightTimeline()
    {

        if (timelinePoint2Fight != null)
        {
            // Play the second timeline
            timelinePoint2Fight.Play();
        }
    }

    void PlayRunafterRunTimeline()
    {

        if (timelinePoint2Run != null)
        {
            // Play the second timeline
            timelinePoint2Run.Play();
        }
    }
    void PlayKillAfterHelpTimeline()
    {

        if (timelinePoint2Kill != null)
        {
            // Play the second timeline
            timelinePoint2Kill.Play();
        }
    }
    void PlayNotKillafterHelpTimeline()
    {

        if (timelinePoint2NotKill != null)
        {
            // Play the second timeline
            timelinePoint2NotKill.Play();
        }
    }
}
