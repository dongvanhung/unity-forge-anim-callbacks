﻿using UnityEngine;

namespace UnityForge.AnimCallbacks.Examples
{
    public class AnimatorAddCallbackExample : MonoBehaviour
    {
        [SerializeField]
        private Animator animator;
        [SerializeField]
        private int layerIndex;
        [SerializeField]
        private string clipName;

        private void Start()
        {
            animator.AddClipStartCallback(layerIndex, clipName, () =>
            {
                Debug.LogFormat("Clip \"{0}\": started", clipName);
            });
            animator.AddClipEndCallback(layerIndex, clipName, () =>
            {
                Debug.LogFormat("Clip \"{0}\": ended", clipName);
            });
            animator.AddClipCallback(layerIndex, clipName, 0.5f, () =>
            {
                Debug.LogFormat("Clip \"{0}\": callback at 0.5f seconds after start", clipName);
            });
        }
    }
}