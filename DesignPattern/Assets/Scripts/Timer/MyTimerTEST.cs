using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ifly_PublicRes
{
    public class MyTimerTEST : MonoBehaviour
    {
        public MyTimer testTimer = new MyTimer();

        // Start is called before the first frame update
        void Start()
        {
            testTimer.duration = 3.0f;
            testTimer.Go();
        }

        // Update is called once per frame
        void Update()
        {
            testTimer.Tick();
            if (testTimer.state == MyTimer.STATE.FINISHED)
            {
                Debug.Log("the timer already finished");
            }
        }
    }
}
