﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

namespace GameEvents
{
    public class GameEventListener : MonoBehaviour
    {
        public GameEvent Event;
        public UnityEvent Response;

        private void OnEnable()
        {
            if (Event != null)
                Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (Event != null)
                Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Response.Invoke();
        }
    }
}
