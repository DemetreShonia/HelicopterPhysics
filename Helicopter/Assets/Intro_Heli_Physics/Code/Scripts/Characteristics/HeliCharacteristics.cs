using UnityEditorInternal;
using UnityEngine;

namespace Shonia
{
	public class HeliCharacteristics : MonoBehaviour
	{
		#region Variables
		[Header("Lift Properties")]
		public float maxLiftForce = 100f;
		public HeliMainRotor mainRotor;
		#endregion
		
		#region Builtin Methods
		void Start()
		{
		
		}
		
		void Update()
		{
		
		}
		#endregion
		
		#region Custom methods
		public void UpdateCharacteristics(Rigidbody rb, InputController input)
		{
			HandleLift(rb, input);
			HandleCyclic(rb, input);
            HandlePedals(rb, input);
        }
        protected virtual void HandleLift(Rigidbody rb, InputController input)
        {
			//print("LIFT");
			Vector3 liftForce = transform.up * (Physics.gravity.magnitude + maxLiftForce) * rb.mass;
			rb.AddForce(liftForce * Mathf.Pow(input.StickyCollectiveInput, 2f), ForceMode.Force); // sqr to 2 because it will be good curve.
		}
        protected virtual void HandleCyclic(Rigidbody rb, InputController input)
        {
        }
        protected virtual void HandlePedals(Rigidbody rb, InputController input) // counter rotation
        {
        }
        #endregion
    }
}
