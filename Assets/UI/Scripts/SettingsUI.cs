using JetBrains.Annotations;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [SerializeField]
    private Button MouseControlButton;
    [SerializeField]
    private Button KeyboardMouseControlButton;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        switch (PlayerSettings.controlType)
        {
            case EControlType.mouse:
                MouseControlButton.image.color = Color.white;
                break;
            case EControlType.keyboardMouse:
                KeyboardMouseControlButton.image.color = Color.green;
                break;
            default:
                break;
        }
    }

    public void SetContorlMode(int controlType)
    {
        PlayerSettings.controlType = (EControlType)controlType;
    }

    public void Close()
    {
        StartCoroutine(CloseAfterDelay());
    }

    private IEnumerator CloseAfterDelay()
    {
        animator.SetTrigger("close");
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
        animator.ResetTrigger("close");
    }
}
