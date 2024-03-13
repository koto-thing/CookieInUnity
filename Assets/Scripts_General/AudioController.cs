using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//オーディオ関連
public static class AudioVariable
{
    public static float BGMvolume;
    public static float SEVolume;
}

//Nullシーン
public class AudioNull
{
    //BGM
    public AudioClip BGMClip;
    public AudioSource BGM1;

    //SE
    public AudioClip SEClip;
    public AudioSource SE1;

    //GameObject
    private GameObject BGM_name;
    private GameObject SE_name;

    public void setUpAudio()
    {
        BGM_name = GameObject.Find("BGM1");
        SE_name = GameObject.Find("SE1");

        BGM1 = BGM_name.GetComponent<AudioSource>();
        SE1 = SE_name.GetComponent<AudioSource>();
    }

    public void playSE()
    {
        SE1.Play();
    }

    public void playBGM()
    {
        BGM1.loop = true;
        BGM1.Play();
    }

    public void toggleBGM()
    {
        if(BGM1.isPlaying == true)
        {
            BGM1.Pause();
        }
        else if(BGM1.isPlaying == false)
        {
            BGM1.Play();
        }
    }

    public void setBGMVolume()
    {
        BGM1.volume = AudioVariable.BGMvolume;
    }

    public void setSEVolume()
    {
        SE1.volume = AudioVariable.SEVolume;
    }
}

//Endシーン
public class AudioEnd
{
    //BGM
    public AudioClip BGMClip;
    public AudioSource BGM1;

    //SE
    public AudioClip SEClip;
    public AudioSource SE1;

    //GameObject
    private GameObject BGM_name;
    private GameObject SE_name;

    public void setUpAudio()
    {
        BGM_name = GameObject.Find("BGM1");
        SE_name = GameObject.Find("SE1");

        BGM1 = BGM_name.GetComponent<AudioSource>();
        SE1 = SE_name.GetComponent<AudioSource>();
    }

    public void playSE()
    {
        SE1.Play();
    }

    public void playBGM()
    {
        BGM1.loop = true;
        BGM1.Play();
    }

    public void toggleBGM()
    {
        if (BGM1.isPlaying == true)
        {
            BGM1.Pause();
        }
        else if (BGM1.isPlaying == false)
        {
            BGM1.Play();
        }
    }

    public void setBGMVolume()
    {
        BGM1.volume = AudioVariable.BGMvolume;
    }

    public void setSEVolume()
    {
        SE1.volume = AudioVariable.SEVolume;
    }
}

//Titleシーン
public class AudioTitle
{
    //BGM
    public AudioClip BGMClip;
    public AudioSource BGM1;

    //SE
    public AudioClip SEClip;
    public AudioSource SE1;

    //GameObject
    private GameObject BGM_name;
    private GameObject SE_name;

    public void setUpAudio()
    {
        BGM_name = GameObject.Find("BGM1");
        SE_name = GameObject.Find("SE1");

        BGM1 = BGM_name.GetComponent<AudioSource>();
        SE1 = SE_name.GetComponent<AudioSource>();
    }

    public void playSE()
    {
        SE1.Play();
    }

    public void playBGM()
    {
        BGM1.loop = true;
        BGM1.Play();
    }

    public void toggleBGM()
    {
        if (BGM1.isPlaying == true)
        {
            BGM1.Pause();
        }
        else if (BGM1.isPlaying == false)
        {
            BGM1.Play();
        }
    }

    public void setBGMVolume()
    {
        BGM1.volume = AudioVariable.BGMvolume;
    }

    public void setSEVolume()
    {
        SE1.volume = AudioVariable.SEVolume;
    }
}


//Optionシーン
public class AudioOption
{
    //BGM
    public AudioClip BGMClip;
    public AudioSource BGM1;

    //SE
    public AudioClip SEClip;
    public AudioSource SE1;

    //GameObject
    private GameObject BGM_name;
    private GameObject SE_name;

    public void setUpAudio()
    {
        BGM_name = GameObject.Find("BGM1");
        SE_name = GameObject.Find("SE1");

        BGM1 = BGM_name.GetComponent<AudioSource>();
        SE1 = SE_name.GetComponent<AudioSource>();
    }

    public void playSE()
    {
        SE1.Play();
    }

    public void playBGM()
    {
        BGM1.loop = true;
        BGM1.Play();
    }

    public void toggleBGM()
    {
        if (BGM1.isPlaying == true)
        {
            BGM1.Pause();
        }
        else if (BGM1.isPlaying == false)
        {
            BGM1.Play();
        }
    }

    public void setBGMVolume()
    {
        BGM1.volume = AudioVariable.BGMvolume;
    }

    public void setSEVolume()
    {
        SE1.volume = AudioVariable.SEVolume;
    }
}

//InGame_Mainシーン
public class AudioInGame_Main
{
    //BGM
    public AudioClip BGMClip;
    public AudioSource BGM1;

    //SE
    public AudioClip SEClip;
    public AudioSource SE1;

    //GameObject
    private GameObject BGM_name;
    private GameObject SE_name;

    public void setUpAudio()
    {
        BGM_name = GameObject.Find("BGM1");
        SE_name = GameObject.Find("SE1");

        BGM1 = BGM_name.GetComponent<AudioSource>();
        SE1 = SE_name.GetComponent<AudioSource>();
    }

    public void playSE()
    {
        SE1.Play();
    }

    public void playBGM()
    {
        BGM1.loop = true;
        BGM1.Play();
    }

    public void toggleBGM()
    {
        if (BGM1.isPlaying == true)
        {
            BGM1.Pause();
        }
        else if (BGM1.isPlaying == false)
        {
            BGM1.Play();
        }
    }

    public void setBGMVolume()
    {
        BGM1.volume = AudioVariable.BGMvolume;
    }

    public void setSEVolume()
    {
        SE1.volume = AudioVariable.SEVolume;
    }
}

//ADVPartシーン
public class AudioADVPart
{
    //BGM
    public AudioClip BGMClip;
    public AudioSource BGM1;

    //SE
    public AudioClip SEClip;
    public AudioSource SE1;

    //GameObject
    private GameObject BGM_name;
    private GameObject SE_name;

    public void setUpAudio()
    {
        BGM_name = GameObject.Find("BGM1");
        SE_name = GameObject.Find("SE1");

        BGM1 = BGM_name.GetComponent<AudioSource>();
        SE1 = SE_name.GetComponent<AudioSource>();
    }

    public void playSE()
    {
        SE1.Play();
    }

    public void playBGM()
    {
        BGM1.loop = true;
        BGM1.Play();
    }

    public void toggleBGM()
    {
        if (BGM1.isPlaying == true)
        {
            BGM1.Pause();
        }
        else if (BGM1.isPlaying == false)
        {
            BGM1.Play();
        }
    }

    public void setBGMVolume()
    {
        BGM1.volume = AudioVariable.BGMvolume;
    }

    public void setSEVolume()
    {
        SE1.volume = AudioVariable.SEVolume;
    }
}

//RPGPartシーン
public class AudioRPGPart
{
    //BGM
    public AudioClip BGMClip;
    public AudioSource BGM1;

    //SE
    public AudioClip SEClip;
    public AudioSource SE1;

    //GameObject
    private GameObject BGM_name;
    private GameObject SE_name;

    public void setUpAudio()
    {
        BGM_name = GameObject.Find("BGM1");
        SE_name = GameObject.Find("SE1");

        BGM1 = BGM_name.GetComponent<AudioSource>();
        SE1 = SE_name.GetComponent<AudioSource>();
    }

    public void playSE()
    {
        SE1.Play();
    }

    public void playBGM()
    {
        BGM1.loop = true;
        BGM1.Play();
    }

    public void toggleBGM()
    {
        if (BGM1.isPlaying == true)
        {
            BGM1.Pause();
        }
        else if (BGM1.isPlaying == false)
        {
            BGM1.Play();
        }
    }

    public void setBGMVolume()
    {
        BGM1.volume = AudioVariable.BGMvolume;
    }

    public void setSEVolume()
    {
        SE1.volume = AudioVariable.SEVolume;
    }
}


public class AudioController : MonoBehaviour
{
    private void Start()
    {
        if(SceneVariable.sceneStatus == SceneVariable.SceneType.NULL)
        {
            AudioNull audionull;
        }
        else if(SceneVariable.sceneStatus == SceneVariable.SceneType.TITLE)
        {
            AudioTitle audioTitle;
        }
        else if(SceneVariable.sceneStatus == SceneVariable.SceneType.OPTION)
        {
            AudioOption audioOption;
        }
        else if(SceneVariable.sceneStatus == SceneVariable.SceneType.INGAME_MAIN)
        {
            AudioInGame_Main audioInGame_Main;
        }
        else if(SceneVariable.sceneStatus == SceneVariable.SceneType.ADVPART)
        {
            AudioADVPart audioADVPart;
        }
        else if(SceneVariable.sceneStatus == SceneVariable.SceneType.RPGPART)
        {
            AudioRPGPart audioRPGPart;
        }
    }

    private void Update()
    {
        if (SceneVariable.sceneStatus == SceneVariable.SceneType.NULL)
        {
            
        }
        else if (SceneVariable.sceneStatus == SceneVariable.SceneType.TITLE)
        {
            
        }
        else if (SceneVariable.sceneStatus == SceneVariable.SceneType.OPTION)
        {
            
        }
        else if (SceneVariable.sceneStatus == SceneVariable.SceneType.INGAME_MAIN)
        {
            
        }
        else if (SceneVariable.sceneStatus == SceneVariable.SceneType.ADVPART)
        {
            
        }
        else if (SceneVariable.sceneStatus == SceneVariable.SceneType.RPGPART)
        {
            
        }
    }
}
