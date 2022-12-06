using Keys;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Signals
{


    public class InputSignals : MonoBehaviour
    {
        #region Singleton

        public static InputSignals Instance;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
        }
        #endregion

        public UnityAction onFirstTimeTouchTaken = delegate { };
        public UnityAction onInputReleased = delegate { };
        public UnityAction onInputTaken = delegate { };
        public UnityAction <HorizontalnputParams> onInputDragged = delegate { };


    }
}
