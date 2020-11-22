using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ifly_PublicRes
{
    public class MyTimer
    {
        public enum STATE
        {
            IDLE,
            RUN,
            FINISHED
        }
        public STATE state;

        public float duration = 0;
        public float ElpsedTime { get; private set; } = 0;

        public void Tick()
        {
            switch (state)
            {
                case STATE.IDLE:
                    break;
                case STATE.RUN:
                    ElpsedTime += Time.deltaTime;
                    if (ElpsedTime >= duration)
                        state = STATE.FINISHED;
                    break;
                case STATE.FINISHED:
                    break;
            }
        }

        public void Go()
        {
            ElpsedTime = 0;
            state = STATE.RUN;
        }
    }
}