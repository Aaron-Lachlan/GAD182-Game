using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject instructionText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InstructionSequence());
    }

    IEnumerator InstructionSequence()
    {
        yield return new WaitForSeconds(5f);
        instructionText.SetActive(false);
        PlayerController.canMove = true;
    }
}
