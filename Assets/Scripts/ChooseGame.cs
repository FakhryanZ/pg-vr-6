using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseGame : MonoBehaviour
{
    public void MoveToGame1(string scene){
        SceneManager.LoadScene(scene);
    }

    public void MoveToGame2(string scene){
        SceneManager.LoadScene(scene);
    }

    public void MoveToGame3(string scene){
        SceneManager.LoadScene(scene);
    }


    public void BackToMenu(string scene){
        SceneManager.LoadScene(scene);
    }
}
