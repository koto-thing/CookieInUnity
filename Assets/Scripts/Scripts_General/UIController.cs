using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//UIä÷òA
public static class UIVariable
{
    public static float Hoge;
    public static long wordCount = 0; //ëçï∂éöêî
}

public class UIController : MonoBehaviour
{
    //private UIEnd UIend;
    //private UITitle UItitle;
    //private UIOption UIoption;
    public UITyping UItyping;
    //private UIADVPart UIadvPart;
    //private UIRPGPart UIrpgpart;

    private void Start()
    {
        switch(SceneVariable.sceneStatus)
        {
            case SceneVariable.SceneType.NULL:
                break;

            case SceneVariable.SceneType.END:
                break;

            case SceneVariable.SceneType.TITLE:
                break;

            case SceneVariable.SceneType.OPTION:
                break;

            case SceneVariable.SceneType.INGAME_MAIN:
                UItyping.UIupdate();
                break;

            case SceneVariable.SceneType.ADVPART:
                break;

            case SceneVariable.SceneType.RPGPART:
                break;
        }
    }

    private void Update()
    {
        
    }
}