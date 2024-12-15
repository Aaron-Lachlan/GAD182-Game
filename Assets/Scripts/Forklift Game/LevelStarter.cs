using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelStarter : MonoBehaviour
{
    public GameObject instructionText;
    public GameObject fadeIn;
    public GameObject countdown5;
    public GameObject countdown4;
    public GameObject countdown3;
    public GameObject countdown2;
    public GameObject countdown1;
    public GameObject go;
    public GameObject winner;
    public GameObject distanceDisplay;
    public GameObject distanceTracker;
    public GameObject loserText;
    public int distanCovered;
    private bool addingDistance = false;
    private bool game = true;
    public bool isWinner = false;
    public Animator animator;
    [SerializeField]
    private PlayerPointSystemSO scoreSO;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(game);
        StartCoroutine(InstructionSequence());
    }

    void Update()
    {
        if(addingDistance == false & PlayerController.canMove == true)
        {
            addingDistance = true;
            StartCoroutine(AddingDistance());
            //Debug.Log("Distance tracking");
        }
    }

    IEnumerator InstructionSequence()
    {
        if (game == true)
        {
            //countdown5.SetActive(true);
            //yield return new WaitForSeconds(1f);
            //countdown4.SetActive(true);
            distanceTracker.SetActive(true);
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
            instructionText.SetActive(false);
            PlayerController.canMove = true;
            //countdown5.SetActive(false);
            //countdown4.SetActive(false);
            countdown3.SetActive(false);
            countdown2.SetActive(false);
            countdown1.SetActive(false);
            go.SetActive(false);
            StartCoroutine(GameTimerSequence());
        }
        else
        {
            instructionText.SetActive(false);
            PlayerController.canMove = true;
            StartCoroutine(GameTimerSequence());
        }
    }
    public IEnumerator AddingDistance()
    {
        distanCovered += 1;
        distanceDisplay.GetComponent<Text>().text = "" + distanCovered;
        scoreSO.Score += distanCovered;
        yield return new WaitForSeconds(0.5f);
        addingDistance = false;
    }
    public IEnumerator GameTimerSequence()
    {
        yield return new WaitForSeconds(10f);
        isWinner = true;
        StartCoroutine(GameComplete());
    }
    public IEnumerator GameComplete()
    {
        PlayerController.canMove = false;
        animator.SetBool("PlayerLeft", false);
        animator.SetBool("PlayerRight", false);
        if (isWinner == true)
        {
            winner.SetActive(true);
        }
        else
            loserText.SetActive(true);

        yield return new WaitForSeconds(5f);
        Debug.Log("NEXT GAME");
        //SceneManager.LoadScene(1);
    }
}
