using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    public Text btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
    public Text p1_score, p2_score;
    public Text winnerText;
    public GameObject winner;
    public GameObject restart;
    public static int score1 = 0;
    public static int score2 = 0;
    public static int count = 0;
    public bool p1_win = false;
    public bool p2_win = false;
    void Update()
    {
        if (btn1.text == "X" && btn2.text == "X" && btn3.text == "X" || btn1.text == "O" && btn2.text == "O" && btn3.text == "O")
        {
            if (btn1.text == "X") p1_win = true;
            else p2_win = true;
            showWinner();
        }
        else if (btn1.text == "X" && btn5.text == "X" && btn9.text == "X" || btn1.text == "O" && btn5.text == "O" && btn9.text == "O")
        {
            if (btn1.text == "X") p1_win = true;
            else p2_win = true;
            showWinner();
        }
        else if (btn1.text == "X" && btn4.text == "X" && btn7.text == "X" || btn1.text == "O" && btn4.text == "O" && btn7.text == "O")
        {
            if (btn1.text == "X") p1_win = true;
            else p2_win = true;
            showWinner();
        }
        else if (btn2.text == "X" && btn5.text == "X" && btn8.text == "X" || btn2.text == "O" && btn5.text == "O" && btn8.text == "O")
        {
            if (btn2.text == "X") p1_win = true;
            else p2_win = true;
            showWinner();
        }
        else if (btn3.text == "X" && btn5.text == "X" && btn7.text == "X" || btn3.text == "O" && btn5.text == "O" && btn7.text == "O")
        {
            if (btn3.text == "X") p1_win = true;
            else p2_win = true;
            showWinner();
        }
        else if (btn3.text == "X" && btn6.text == "X" && btn9.text == "X" || btn3.text == "O" && btn6.text == "O" && btn9.text == "O")
        {
            if (btn3.text == "X") p1_win = true;
            else p2_win = true;
            showWinner();
        }
        else if (btn4.text == "X" && btn5.text == "X" && btn6.text == "X" || btn4.text == "O" && btn5.text == "O" && btn6.text == "O")
        {
            if (btn4.text == "X") p1_win = true;
            else p2_win = true;
            showWinner();
        }
        else if (btn7.text == "X" && btn8.text == "X" && btn9.text == "X" || btn7.text == "O" && btn8.text == "O" && btn9.text == "O")
        {
            if (btn7.text == "X") p1_win = true;
            else p2_win = true;
            showWinner();
        }
        else if(count == 9 && p1_win != true && p2_win != true)
        {
            winnerText.text = "Draw! No one win.";
            showWinner();
        }

    }
    public void onClick()
    {
        count++;
    }
    public void Restart()
    {
        count = 0;
        btn1.text = btn2.text = btn3.text = btn4.text = btn5.text = btn6.text = btn7.text = btn8.text = btn9.text = "";
        if (p1_win == true)
        {
            score1++;
            p1_win = false;
        }
        else if (p2_win == true)
        {
            score2++;
            p2_win = false;
        }
        Score();
        winner.SetActive(false);
        restart.SetActive(false);
    }
    void Score()
    {
        p1_score.text = score1.ToString();
        p2_score.text = score2.ToString();
    }
    void showWinner()
    {
        if (p1_win == true) winnerText.text = "Player 1 Win!";
        else if (p2_win == true) winnerText.text = "Player 2 Win!";
        winner.SetActive(true);
        restart.SetActive(true);
    }
}
