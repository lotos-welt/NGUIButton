/*!
 * ボタン実行サンプルクラス.
 * 
 * @file	Sample.cs
 * @author	Lotos
 * @date	2016-01-20 01:16
 */

using UnityEngine;
using System.Collections;

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
