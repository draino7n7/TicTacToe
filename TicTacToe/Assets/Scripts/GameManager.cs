using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text gameMessage;

    public GameObject button00;
    public GameObject button01;
    public GameObject button02;
    public GameObject button10;
    public GameObject button11;
    public GameObject button12;
    public GameObject button20;
    public GameObject button21;
    public GameObject button22;


    private GameObject[,] gameObjects;
    private bool turnX;
    private bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameObjects = new GameObject[3, 3];
        gameObjects[0, 0] = button00;
        gameObjects[0, 1] = button01;
        gameObjects[0, 2] = button02;
        gameObjects[1, 0] = button10;
        gameObjects[1, 1] = button11;
        gameObjects[1, 2] = button12;
        gameObjects[2, 0] = button20;
        gameObjects[2, 1] = button21;
        gameObjects[2, 2] = button22;
        NewGame();
    }

    private void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Exit the application
            Application.Quit();

            // If running in the editor, stop playing
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }

    public void NewGameButtonPress()
    {
        NewGame();
    }

    public void GameButtonPress(string id)
    {
        string xString = id.Split('|')[0];
        string yString = id.Split('|')[1];
        int x = int.Parse(xString);
        int y = int.Parse(yString);
        if (!gameOver && gameObjects[x, y].GetComponentInChildren<TMP_Text>().text == "")
        {
            if (turnX)
            {
                gameObjects[x, y].GetComponentInChildren<TMP_Text>().text = "X";
            }
            else
            {
                gameObjects[x, y].GetComponentInChildren<TMP_Text>().text = "O";
            }
            turnX = !turnX;
            if (turnX)
            {
                gameMessage.text = "Turn: X";
            }
            else
            {
                gameMessage.text = "Turn: O";
            }
            CheckWinner();
        }
    }

    private void CheckWinner()
    {
        for (int x = 0; x < 3; x++)
        {
            if (gameObjects[x, 0].GetComponentInChildren<TMP_Text>().text == gameObjects[x, 1].GetComponentInChildren<TMP_Text>().text
                && gameObjects[x, 0].GetComponentInChildren<TMP_Text>().text == gameObjects[x, 2].GetComponentInChildren<TMP_Text>().text)
            {
                if (gameObjects[x, 0].GetComponentInChildren<TMP_Text>().text == "X")
                {
                    gameOver = true;
                    gameMessage.text = "X Wins";
                    return;
                }
                else if(gameObjects[x, 0].GetComponentInChildren<TMP_Text>().text == "O")
                {
                    gameOver = true;
                    gameMessage.text = "O Wins";
                    return;
                }
            }
        }

        for (int y = 0; y < 3; y++)
        {
            if (gameObjects[0, y].GetComponentInChildren<TMP_Text>().text == gameObjects[1, y].GetComponentInChildren<TMP_Text>().text
                && gameObjects[0, y].GetComponentInChildren<TMP_Text>().text == gameObjects[2, y].GetComponentInChildren<TMP_Text>().text)
            {
                if (gameObjects[0, y].GetComponentInChildren<TMP_Text>().text == "X")
                {
                    gameOver = true;
                    gameMessage.text = "X Wins";
                    return;
                }
                else if (gameObjects[0, y].GetComponentInChildren<TMP_Text>().text == "O")
                {
                    gameOver = true;
                    gameMessage.text = "O Wins";
                    return;
                }
            }
        }

        if ((gameObjects[0, 0].GetComponentInChildren<TMP_Text>().text == gameObjects[1, 1].GetComponentInChildren<TMP_Text>().text
            && gameObjects[0, 0].GetComponentInChildren<TMP_Text>().text == gameObjects[2, 2].GetComponentInChildren<TMP_Text>().text)
            || (gameObjects[0, 2].GetComponentInChildren<TMP_Text>().text == gameObjects[1, 1].GetComponentInChildren<TMP_Text>().text
            && gameObjects[2, 0].GetComponentInChildren<TMP_Text>().text == gameObjects[1, 1].GetComponentInChildren<TMP_Text>().text))
        {
            if (gameObjects[1, 1].GetComponentInChildren<TMP_Text>().text == "X")
            {
                gameOver = true;
                gameMessage.text = "X Wins";
                return;
            }
            else if (gameObjects[1, 1].GetComponentInChildren<TMP_Text>().text == "O")
            {
                gameOver = true;
                gameMessage.text = "O Wins";
                return;
            }
        }

        bool allFull = true;
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (gameObjects[x, y].GetComponentInChildren<TMP_Text>().text == "")
                {
                    allFull = false;
                }
            }
        }
        if (allFull) 
        {
            gameOver = true;
            gameMessage.text = "Draw";
        }

    }

    private void NewGame()
    {
        gameMessage.text = "Turn: X";
        turnX = true;
        gameOver = false;
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                gameObjects[x, y].GetComponentInChildren<TMP_Text>().text = "";
            }
        }
    }
}
