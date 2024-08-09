using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


namespace Utils
{
    public class CustomSimpleInteractable : XRSimpleInteractable
    {
        [SerializeField] public string animNameToPlay;
        [SerializeField, Tooltip("Should this grabbable play default fist animation on grab.")]
        bool shouldUseDefaultFistAnim = false;

        public bool ShouldUseDefaultFistAnim { get => shouldUseDefaultFistAnim; set => shouldUseDefaultFistAnim = value; }
    }
}