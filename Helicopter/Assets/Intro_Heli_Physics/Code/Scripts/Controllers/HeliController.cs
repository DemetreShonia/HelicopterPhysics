using UnityEngine;

namespace Shonia
{
    [RequireComponent(typeof(InputController))]
    public class HeliController : BaseRBController
	{
		#region Variables
		InputController _input;
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
        protected override void HandlePhysics()
        {
			if(_input != null)
			{
                HandleEngines();
                HandleCharacteristics();
            }
            else
            {
                _input  = GetComponent<InputController>();
            }
        }

        #endregion

        #region Helicopter Controler Methods

        protected virtual void HandleEngines()
        {

        }
        protected virtual void HandleCharacteristics()
        {

        }

        #endregion
    }
}
