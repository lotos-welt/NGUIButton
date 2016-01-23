/************************************************
Sample.cs

Copyright (c) 2016 LotosLabo

This software is released under the MIT License.
http://opensource.org/licenses/mit-license.php
************************************************/

using UnityEngine;
using System.Collections;

/* ボタン実行サンプルクラス. */
public class Sample : MonoBehaviour
{
    #region UI
    /// <summary>
    /// サンプルボタン.
    /// </summary>
    public NGUIButton sampleBtn;
    #endregion

    void Start() {
        // クリックイベントの登録.
        sampleBtn.Click += SampleBtnClickHandler;
    }

    /// <summary>
    /// ボタンの処理.
    /// </summary>
    private void SampleBtnClickHandler(object sender, System.EventArgs e) {
        Debug.Log("Hello World!");
    }

}
