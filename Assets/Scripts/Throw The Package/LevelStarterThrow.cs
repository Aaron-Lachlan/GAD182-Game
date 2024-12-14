using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelStarterThrow : MonoBehaviour
{
    public GameObject instructionText;
    public GameObject fadeIn;
    public GameObject countdown3;
    public GameObject countdown2;
    public GameObject countdown1;
    public GameObject go;
    public GameObject reticle;
    public GameObject scoreTotal;
    public GameObject scoreTotalContainer;
    public GameObject scoreTracker;
    private bool game = false;
    public BoxTrigger boxTrigger;
    public MouseLook mouseLook;
    private int gameTime = 15;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(game);
        StartCoroutine(InstructionSequence());
    }
    IEnumerator InstructionSequence()
    {
        if (game == true)
        {
            scoreTracker.SetActive(true);
            fadeIn.SetActive(true);
            yield return new WaitForSeconds(1f);
            countdown3.SetActive(true);
            instructionText.SetActive(true);
            yield return new WaitForSeconds(1f);
            countdown2.SetActive(true);
            yield return new WaitForSeconds(1f);
            countdown1.SetActive(true);
            yield return new WaitForSeconds(1f);
            go.SetActive(true);
            reticle.SetActive(true);
            mouseLook.canLook = true;
            yield return new WaitForSeconds(1f);
            instructionText.SetActive(false);
            countdown3.SetActive(false);
            countdown2.SetActive(false);
            countdown1.SetActive(false);
            go.SetActive(false);
            StartCoroutine(GameTimerSequence());
        }
        else
        {
            mouseLook.canLook = true;
            scoreTracker.SetActive(true);
            reticle.SetActive(true);
            instructionText.SetActive(false);
            StartCoroutine(GameTimerSequence());
        }
    }
    IEnumerator GameTimerSequence()
    {
        if(gameTime != 0)
        {
            yield return new WaitForSeconds(1f);
            gameTime -= 1;
            Debug.Log(gameTime);
            StartCoroutine(GameTimerSequence());
        }
        else
            StartCoroutine(EndGameSequence());
    }
    IEnumerator EndGameSequence()
    {
        mouseLook.canLook = false;
        scoreTotal.GetComponent<Text>().text = "" + boxTrigger.playerScore;
        scoreTotalContainer.SetActive(true);

        yield return new WaitForSeconds(5f);
        Debug.Log("NEXT GAME");
        //SceneManager.LoadScene(1);
    }
}
