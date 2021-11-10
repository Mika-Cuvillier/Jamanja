using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionChangementScenes : MonoBehaviour
{
    public static void Defaite()
    {
        sceneloader.instance.LoadScene("Defaite");
    }

    public static void Victoire()
    {
        sceneloader.instance.LoadScene("Victoire");
    }

    public static void Temple()
    {
        sceneloader.instance.LoadScene("Temple");
    }

    public static void Donjon()
    {
        sceneloader.instance.LoadScene("Donjon");
    }

    public static void CabinePirate()
    {
        sceneloader.instance.LoadScene("CabinePirate");
    }

    public static void Lobby()
    {
        sceneloader.instance.LoadScene("Lobby");
    }
}
