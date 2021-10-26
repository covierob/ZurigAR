using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickDisable : MonoBehaviour
{
    [SerializeField]
    private Button button;

    [SerializeField]
    private GameObject content;

    private void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        if (content.gameObject.activeSelf)
        {
            content.gameObject.SetActive(false);
        }
        else
        {
            content.gameObject.SetActive(true);
        }
    }
}
