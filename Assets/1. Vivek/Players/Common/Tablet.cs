using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Utils 
{
    public class Tablet : MonoBehaviour
    {
        public UnityEvent OnLanguageButtonClick;

        [SerializeField] public TMP_FontAsset[] languagesFont;
        [SerializeField] public TextMeshProUGUI taskDetailText;
        [SerializeField] public UnityEngine.UI.Button confirmButton, relearnButton, homeButton, quitButton, skipButton;
        [SerializeField] public GameObject experimentUI;
        [SerializeField] bool onState = true;
        [SerializeField] GameObject tablet;

        public bool OnState { get => onState; set => onState = value; }

        /// <summary>
        /// For explicitily setting the on state.
        /// </summary>
        /// <param name="on">true for on</param>
        public void SetTabletOnState(bool on = true)
        {
            OnState = on;
            tablet.SetActive(OnState);
        }

        /// <summary>
        /// For setting the state on if it was off & vice versa
        /// </summary>
        public void ToggleTabletOn()
        {
            OnState = !OnState;
            SetTabletOnState(OnState);
        }

        public void OnXButtonPress()
        {
            ToggleTabletOn();
        }

        public void OnLanguageButtonClicked()
        {
            OnLanguageButtonClick?.Invoke();
        }
    }
}