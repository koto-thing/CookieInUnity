using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//シーン遷移
public static class SceneVariable
{
    /*変数群*/
    //シーンの種類
    public enum SceneType
    {
        NULL, //エラー用
        END, //ゲーム終了
        TITLE, //タイトル
        OPTION, //オプション
        INGAME_MAIN, //ゲーム
        ADVPART, //ADVパート
        RPGPART, //RPGパート
    }

    public static SceneType sceneStatus; //現在のシーンの状態を記録
}

public class SceneController : MonoBehaviour
{
    /*デバッグ用*/
    public void Update()
    {
        if(SceneVariable.sceneStatus == SceneVariable.SceneType.NULL)
        {
            Debug.Log("Error Occured!\n" + "sceneStatus = " + SceneVariable.sceneStatus + "\n" + "シーンステータスがNULLです");
        }
    }

    /*シーン遷移に関する関数群*/
    //InGame_Mainへ
    public void onClickGameStartButton()
    {
        Debug.Log("InGame_Mainに移動します");
        SceneVariable.sceneStatus =  SceneVariable.SceneType.INGAME_MAIN;
        Invoke("changeIngame", 1.5f);
    }

    public void changeIngame()
    {
        SceneManager.LoadScene("InGame_Main");
    }

    //Optionへ
    public void onClickOptionButton()
    {
        Debug.Log("Optionへ移動します");
        SceneVariable.sceneStatus = SceneVariable.SceneType.OPTION;
        Invoke("changeOption", 1.5f);
    }

    public void changeOption()
    {
        SceneManager.LoadScene("Option");
    }

    //ADVパートへ
    public void onClickADVPartButton()
    {
        Debug.Log("ADVパートに移ります");
        SceneVariable.sceneStatus = SceneVariable.SceneType.ADVPART;
        Invoke("changeADVPart", 1.5f);
    }

    public void changeADVPart()
    {
        SceneManager.LoadScene("ADVPart");
    }

    //RPGパートへ
    public void onClickRPGPartButton()
    {
        Debug.Log("RPGパートへ移ります");
        SceneVariable.sceneStatus = SceneVariable.SceneType.RPGPART;
        Invoke("changeRPGPart", 1.5f);
    }

    public void changeRPGPart()
    {
        SceneManager.LoadScene("RPGPart");
    }

    //ゲーム終了時
    public void onClickGameEndButton()
    {
        Debug.Log("ゲーム終了します");
        SceneVariable.sceneStatus = SceneVariable.SceneType.END;
        Invoke("gameEnd", 1.5f);
    }

    public void gameEnd()
    {
        //エディタでの再生を停止
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        //実行中のビルドでのアプリケーションを停止
        #else
                Application.Quit();
        #endif
    }
}
