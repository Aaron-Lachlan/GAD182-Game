using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoxPoints : MonoBehaviour
{
    [SerializeField]
    private PlayerPointSystemSO scoreSO;
    
    public TextMeshProUGUI pointText;

    private void Start()
    {
        pointText.text = "Points:" + scoreSO.Score;
    }
    // Update is called once per frame
    void Update()
    {
        Points();
    }

    void Points()
    {
        if (Input.GetMouseButtonDown(1))
        {
            scoreSO.Score += 100;
            pointText.text = "Points:" + scoreSO.Score;
        }
    }
}
