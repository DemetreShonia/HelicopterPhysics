using UnityEngine;

namespace Shonia
{
	public enum InputType
	{
		Keyboard,
		Xbox,
		Mobile
	}
	public class InputController : MonoBehaviour
	{
		#region Variables
		public InputType inputType = InputType.Keyboard;
		[Header("Input Components")]
		public KeyBoardHeliInput keyInput;
		public XboxHeliInput xboxInput;
        #endregion

        #region Builtin Methods
        void Start()
		{
			SetInputType(inputType);
		}

		#endregion

		#region Custom methods
		void SetInputType(InputType type)
		{
			inputType = type;
			if(keyInput && xboxInput)
			{
                if (type == InputType.Keyboard)
                {
                    keyInput.enabled = true;
                    xboxInput.enabled = false;
                }
                if (type == InputType.Xbox)
                {
                    keyInput.enabled = false;
                    xboxInput.enabled = true;
                }
            }
			
		}
		#endregion
	}
}
