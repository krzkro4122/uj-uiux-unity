using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SceneToggler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private GameObject _screen_primary;
    [SerializeField] private GameObject _screen_secondary;

    public void OnPointerDown(PointerEventData eventData)
    {
        return;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        return;
    }

    public void IWasClicked()
    {
        _screen_primary.SetActive(false);
        _screen_secondary.SetActive(true);
    }

    public void IWasSummoned()
    {
        _screen_primary.SetActive(true);
    }

    public void IWasBanished()
    {
        _screen_primary.SetActive(false);
    }
}
