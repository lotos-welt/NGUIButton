/*!
 * ボタン処理クラス.
 * 
 * @file	NGUIButton.cs
 * @author	Lotos
 * @date	2015-10-23 00:05
 */

using UnityEngine;
using System.Collections;

[AddComponentMenu("LotosLabo/Event/NGUIButton")]
[RequireComponent(typeof(BoxCollider))]
public class NGUIButton : MonoBehaviour
{
    /// <summary>
    /// ボタンタイプ.
    /// </summary>
    public enum ButtonTypes {
        None = 0, // 未定義.
        Submit, // 決定.
        Decide, // 大決定.
        Tab, // タブ.
        Transition, // 画面遷移.
        Cancel
    }

    /// <summary>
    /// ボタンタイプデフォルト.
    /// </summary>
    public ButtonTypes Type = ButtonTypes.None;

    private bool isEnable = true;
    /// <summary>
    /// クリック可能か.
    /// </summary>
    public bool ClickEnabled {
        get { return isEnable; }
        set { isEnable = value; }
    }

    /// <summary>
    /// クリックイベントハンドラ.
    /// </summary>
    public event System.EventHandler Click;

    /// <summary>
    /// クリック処理.
    /// </summary>
    private void OnClick() {
        if (!isEnable) return;

        // SEの再生.
        PlaySE();

        // イベントの登録.
        if (Click != null) Click(this, new System.EventArgs());
    }

    /// <summary>
    /// マスクをかける処理.
    /// </summary>
    /// <param name="isEnable">マスクをかけるか、かけないか.</param>
    public void MaskEnable(bool isEnable) {
        if (isEnable) {
            this.gameObject.GetComponent<UISprite>().color = new Color32(88, 88, 88, 255);
        } else {
            this.gameObject.GetComponent<UISprite>().color = new Color32(255, 255, 255, 255);
        }
    }

    /// <summary>
    /// すべての子オブジェクトにマスクをかける処理.
    /// </summary>
    /// <param name="isEnable">マスクをかけるか、かけないか.</param>
    public void AllMaskEnable(GameObject obj, bool isEnable) {
        var componentsSprite = TransformResearch.SelfGetComponentArray<UISprite>(obj, true);
        foreach (var sprite in componentsSprite) {
            if (isEnable) {
             sprite.color = new Color32(88, 88, 88, 255);
            } else {
             sprite.color = new Color32(255, 255, 255, 255);
            }
        }
    }

    /// <summary>
    /// SE再生.
    /// </summary>
    private void PlaySE() {
        switch (Type) {
            case ButtonTypes.Submit:
                // SE再生.
                break;
            case ButtonTypes.Decide:
                // SE再生.
                break;
            case ButtonTypes.Tab:
                // SE再生.
                break;
            case ButtonTypes.Transition:
                // SE再生.
                break;
            case ButtonTypes.Cancel:
                // SE再生.
                break;
        }
    }

	
}
