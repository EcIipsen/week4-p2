using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use

		public string SteeringAxis = "Horizontal";
		public string AccelerationBrakeAxis = "Vertical";
		//public string HandbrakeAxis = "Jump";

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
			//float h = CrossPlatformInputManager.GetAxis(SteeringAxis);
			//float v = CrossPlatformInputManager.GetAxis(AccelerationBrakeAxis);
			float h = Input.GetAxis(SteeringAxis);
			float v = Input.GetAxis(AccelerationBrakeAxis);

			//print (h);
			print (v);

#if !MOBILE_INPUT
			//float handbrake = CrossPlatformInputManager.GetAxis(HandbrakeAxis);
			m_Car.Move(h, v, v, 0.0f);//handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
