using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcherButt : MonoBehaviour
{
    public void SwitchScene(string st)
    {
        SceneManager.LoadScene(st);
    }
}
