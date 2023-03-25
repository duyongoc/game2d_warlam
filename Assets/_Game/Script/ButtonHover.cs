using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{


    [SerializeField] private GameObject objButton;


    #region UNITY
    // private void OnEnable()
    // {
    // }

    private void OnDisable()
    {
        OnEffectOut();
    }
    #endregion



    public void OnPointerEnter(PointerEventData eventData)
    {
        // print("OnPointerEnter");
        OnEffectIn();
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        // print("OnPointerClick");
        OnEffectIn();
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        OnEffectOut();
    }


    private void OnEffectIn()
    {
        transform.DOKill();
        transform.DOScale(Vector3.one * 1.5f, 1);
    }


    private void OnEffectOut()
    {
        transform.DOKill();
        transform.DOScale(Vector3.one, 1);
    }

}
