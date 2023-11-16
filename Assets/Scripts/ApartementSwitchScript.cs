using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class ApartementSwitchScript : MonoBehaviour
{
    // Start is called before the first frame update
   // Reference to the Timeline
    public PlayableDirector timeline;

    void Start()
    {
        // Subscribe to the Timeline's signal event
        timeline.stopped += OnTimelineStopped;
    }

    // This method is called when the Timeline finishes playing
    void OnTimelineStopped(PlayableDirector director)
    {
        // Check if the Director is the one we are interested in
        if (director == timeline)
        {
            // Switch to the next scene
            SwitchScene();
        }
    }

    void SwitchScene()
    {
        // Replace "YourNextSceneName" with the name of your next scene
        SceneManager.LoadScene("Street");
    }
}
