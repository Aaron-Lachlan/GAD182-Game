using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class PlayerPoints : MonoBehaviour
{
    [SerializeField]
    private PlayerPointSystemSO scoreSO;
    public Timer timerScript;
    [SerializeField]
    public TextMeshProUGUI pointText;

    // Start is called before the first frame update
    void Start()
    {
        pointText.text = "Points:" + scoreSO.Score;
        
    }

    // Update is called once per frame
    void Update()
    {
        PointAllocation();
    }

    void PointAllocation()
    {
        if (Input.GetMouseButtonDown(0))
        {
            

                scoreSO.Score += 10;
                pointText.text = "Points:" + scoreSO.Score;
          

        }
    }


}
