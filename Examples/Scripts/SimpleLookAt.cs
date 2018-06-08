// Licensed under Unity Asset Store EULA Editor Extensions one license per seat
// Copyright 2018 Parkerhill Technology Corporation www.parkerhill.com

using System.Collections;
using UnityEngine;

namespace BridgeXR.Examples.Scripts
{
    public class SimpleLookAt : MonoBehaviour
    {
        private bool lookAtEnabled;
        private Quaternion startRotation;

        [SerializeField] private Transform targetTransform;

        private void Awake()
        {
            startRotation = transform.rotation;
        }


        public void EnableLookAt(bool enabled)
        {
            lookAtEnabled = enabled;
            StartCoroutine(lookAtEnabled ? DoLookAt() : DoResetRotation());
        }

        private IEnumerator DoResetRotation()
        {
            Quaternion currentRotation = transform.rotation;
            float currentTime = Time.time;
            float timeToComplete = .5f;
            float fracComplete = 0;

            while (lookAtEnabled == false && fracComplete < 1)
            {
                fracComplete = (Time.time - currentTime) / timeToComplete;
                transform.rotation = Quaternion.Slerp(currentRotation, startRotation, fracComplete);
                yield return 0;
            }
        }

        private IEnumerator DoLookAt()
        {
            while (lookAtEnabled)
            {
                Quaternion targetRotation = Quaternion.LookRotation(targetTransform.position - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2);
                yield return 0;
            }
        }
    }
}