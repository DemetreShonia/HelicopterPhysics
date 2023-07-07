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


        float _throttleInput = 0f;
        float _collectiveInput = 0f;
        Vector2 _cyclicInput = Vector2.zero;
        float _pedalInput = 0f;
        float _stickyThrottleInput;

        public float ThrottleInput => _throttleInput;
        public float StickyThrottleInput => _stickyThrottleInput;
        public float CollectiveInput => _collectiveInput;
        public Vector2 CyclicInput => _cyclicInput;
        public float PedalInput => _pedalInput;

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

        void Update()
        {
            if (_keyInput && _xboxInput)
            {
                switch (inputType)
                {
                    case InputType.Keyboard:
                        _throttleInput = _keyInput.RawThrottleInput;
                        _collectiveInput = _keyInput.CollectiveInput;
                        _cyclicInput = _keyInput.CyclicInput;
                        _pedalInput = _keyInput.PedalInput;
                        _stickyThrottleInput = _keyInput.StickyThrottle;
                        break;
                    case InputType.Xbox:
                        _throttleInput = _xboxInput.RawThrottleInput;
                        _collectiveInput = _xboxInput.CollectiveInput;
                        _cyclicInput = _xboxInput.CyclicInput;
                        _pedalInput = _xboxInput.PedalInput;
                        _stickyThrottleInput = _xboxInput.StickyThrottle;
                        break;
                } 
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
