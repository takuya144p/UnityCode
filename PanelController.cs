using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject NarrationText1;

    enum Panel
    {
        MainMenuPanel,
        GamePanel,
    }

    Panel currentPanel = Panel.MainMenuPanel;

    public void OnStartButton()
    {
        this.transform.localPosition = new Vector2(0, 0);
        currentPanel = Panel.GamePanel;
        NarrationText1.SetActive(true);
    }
}
