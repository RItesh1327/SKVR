using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Utils
{
    public class CustomXRGrabInteractable : XRGrabInteractable
    {
        [SerializeField] GameObject rightHandRay, leftHandRay;
        [SerializeField] public string animNameToPlay;
        [SerializeField] internal InteractorType grabbedInteractorType = InteractorType.None;
        [SerializeField] Transform leftHandAttachTransform, rightHandAttachTransform;
        [SerializeField, Tooltip("Should this grabbable play default fist animation on grab.")]
        bool shouldUseDefaultFistAnim = false;
        Transform InitialLAT,InitialRAT;
        string initialAnimToPlay;
        bool IsGrabbed;

        private void Start()
        {
            InitialLAT = leftHandAttachTransform;
            InitialRAT = rightHandAttachTransform;
            initialAnimToPlay = animNameToPlay;
        }

        public InteractorType GetInteractorType()
        {
            return grabbedInteractorType;
        }
        public bool ShouldUseDefaultFistAnim { get => shouldUseDefaultFistAnim; set => shouldUseDefaultFistAnim = value; }

        public void ChangeAnimNameToPlay(string nameOfAnim)
        {
            animNameToPlay = nameOfAnim;
        }

        public void ResetAnimNameToPlay()
        {
            animNameToPlay = initialAnimToPlay;
        }
        public void ChangeLeftAttachTransform(Transform left)
        {
            leftHandAttachTransform = left;            
        }

        public void ChangeRightAttachTransform(Transform right)
        {
            rightHandAttachTransform = right;
        }
        public void ResetAttachTransform()
        {
            leftHandAttachTransform = InitialLAT;
            rightHandAttachTransform = InitialRAT;
        }
        

        public void DetermineInteractorType(XRBaseInteractor interactor)
        {
            if (interactor.CompareTag(_Constants.LEFT_HAND_TAG))
                grabbedInteractorType = InteractorType.LeftHand;
            else if (interactor.CompareTag(_Constants.RIGHT_HAND_TAG))
                grabbedInteractorType = InteractorType.RightHand;
            else if (interactor is XRSocketInteractor)
                grabbedInteractorType = InteractorType.Socket;
        }

        public void SetAttachTransform()
        {
            switch (grabbedInteractorType)
            {
                case InteractorType.LeftHand:
                    attachTransform = leftHandAttachTransform;
                    break;
                case InteractorType.RightHand:
                    attachTransform = rightHandAttachTransform;
                    break;
            }
        }

        protected override void OnSelectEntered(SelectEnterEventArgs args)
        {
            DetermineInteractorType(args.interactor);
            SetAttachTransform();
            base.OnSelectEntered(args);

            /*if (grabbedInteractorType == InteractorType.LeftHand)
            {
                leftHandRay.SetActive(false);
            }
            else if (grabbedInteractorType == InteractorType.RightHand)
            {
                rightHandRay.SetActive(false);
            }*/
        }

        protected override void OnSelectExited(SelectExitEventArgs args)
        {
            /*if (grabbedInteractorType == InteractorType.LeftHand)
            {
                leftHandRay.SetActive(true);
            }
            else if (grabbedInteractorType == InteractorType.RightHand)
            {
                rightHandRay.SetActive(true);
            }*/
            base.OnSelectExited(args);
            grabbedInteractorType = InteractorType.None;
        }

        public void ToggleIsGrabbed(bool isGrabbed)
        {
            IsGrabbed = isGrabbed;
        }

        public bool IsObjGrabbed()
        {
            return IsGrabbed;
        }
        [System.Serializable]
        public enum InteractorType
        {
            None, LeftHand, RightHand, Socket
        }
    }
}