using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITyping : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI wordCountText; //総文字数を表示するテキスト

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {

    }

    public void UIupdate()
    {
        wordCountText.text = UIVariable.wordCount.ToString() + "moji";
    }
}
