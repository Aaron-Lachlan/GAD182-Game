using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombineScore : MonoBehaviour
{
    [SerializeField]
    private PlayerPointSystemSO scoreSO;
    public Text scoreTotal;
    // Start is called before the first frame update
    void Start()
    {
        scoreTotal.GetComponent<Text>().text = "Final Score: " + scoreSO.Score;
    }
}
