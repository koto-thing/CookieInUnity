using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//�V�[���J��
public static class SceneVariable
{
    /*�ϐ��Q*/
    //�V�[���̎��
    public enum SceneType
    {
        NULL, //�G���[�p
        END, //�Q�[���I��
        TITLE, //�^�C�g��
        OPTION, //�I�v�V����
        INGAME_MAIN, //�Q�[��
        ADVPART, //ADV�p�[�g
        RPGPART, //RPG�p�[�g
    }

    public static SceneType sceneStatus; //���݂̃V�[���̏�Ԃ��L�^
}

public class SceneController : MonoBehaviour
{
    /*�f�o�b�O�p*/
    public void Update()
    {
        if(SceneVariable.sceneStatus == SceneVariable.SceneType.NULL)
        {
            Debug.Log("Error Occured!\n" + "sceneStatus = " + SceneVariable.sceneStatus + "\n" + "�V�[���X�e�[�^�X��NULL�ł�");
        }
    }

    /*�V�[���J�ڂɊւ���֐��Q*/
    //InGame_Main��
    public void onClickGameStartButton()
    {
        Debug.Log("InGame_Main�Ɉړ����܂�");
        SceneVariable.sceneStatus =  SceneVariable.SceneType.INGAME_MAIN;
        Invoke("changeIngame", 1.5f);
    }

    public void changeIngame()
    {
        SceneManager.LoadScene("InGame_Main");
    }

    //Option��
    public void onClickOptionButton()
    {
        Debug.Log("Option�ֈړ����܂�");
        SceneVariable.sceneStatus = SceneVariable.SceneType.OPTION;
        Invoke("changeOption", 1.5f);
    }

    public void changeOption()
    {
        SceneManager.LoadScene("Option");
    }

    //ADV�p�[�g��
    public void onClickADVPartButton()
    {
        Debug.Log("ADV�p�[�g�Ɉڂ�܂�");
        SceneVariable.sceneStatus = SceneVariable.SceneType.ADVPART;
        Invoke("changeADVPart", 1.5f);
    }

    public void changeADVPart()
    {
        SceneManager.LoadScene("ADVPart");
    }

    //RPG�p�[�g��
    public void onClickRPGPartButton()
    {
        Debug.Log("RPG�p�[�g�ֈڂ�܂�");
        SceneVariable.sceneStatus = SceneVariable.SceneType.RPGPART;
        Invoke("changeRPGPart", 1.5f);
    }

    public void changeRPGPart()
    {
        SceneManager.LoadScene("RPGPart");
    }

    //�Q�[���I����
    public void onClickGameEndButton()
    {
        Debug.Log("�Q�[���I�����܂�");
        SceneVariable.sceneStatus = SceneVariable.SceneType.END;
        Invoke("gameEnd", 1.5f);
    }

    public void gameEnd()
    {
        //�G�f�B�^�ł̍Đ����~
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        //���s���̃r���h�ł̃A�v���P�[�V�������~
        #else
                Application.Quit();
        #endif
    }
}
