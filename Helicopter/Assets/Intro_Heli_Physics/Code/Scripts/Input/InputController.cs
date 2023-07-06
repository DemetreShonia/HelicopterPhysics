using UnityEngine;

namespace Shonia
{
	public enum InputType
	{
		Keyboard,
		Xbox,
		Mobile
	}
    [RequireComponent(typeof(KeyBoardHeliInput), typeof(XboxHeliInput))]

    public class InputController : MonoBehaviour
	{
		#region Variables
		[Header("Input Properties")]
		public InputType inputType = InputType.Keyboard;
		KeyBoardHeliInput _keyInput;
		XboxHeliInput _xboxInput;
        #endregion

        #region Builtin Methods
        void Start()
		{
			_keyInput= GetComponent<KeyBoardHeliInput>();
			_xboxInput = GetComponent<XboxHeliInput>();
            if (_keyInput && _xboxInput)
            {
                SetInputType(inputType);
            }
        }

		#endregion

		#region Custom methods
		void SetInputType(InputType type)
		{
			//inputType = type;
			
            if (type == InputType.Keyboard)
            {
                _keyInput.enabled = true;
                _xboxInput.enabled = false;
            }
            if (type == InputType.Xbox)
            {
                _keyInput.enabled = false;
                _xboxInput.enabled = true;
            }
        }
		#endregion
	}
}
