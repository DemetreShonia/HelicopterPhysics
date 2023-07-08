using UnityEngine;

namespace Shonia
{
    public class KeyBoardHeliInput : BaseHeliInput
    {
        #region Variables
        [Header("Heli Keyboard Inputs")]
        protected float _throttleInput = 0f;
        protected float _collectiveInput = 0f;
        protected float _stickyCollectiveInput = 0f;
        protected Vector2 _cyclicInput = Vector2.zero;
        protected float _pedalInput = 0f;
        private float _stickyThrottle;

        public float RawThrottleInput => _throttleInput;
        public float CollectiveInput => _collectiveInput;
        public Vector2 CyclicInput => _cyclicInput;
        public float PedalInput => _pedalInput;

        public float StickyThrottle => _stickyThrottle;
        public float StickyCollectiveInput => _stickyCollectiveInput;
        #endregion

        #region Builtin Methods

        #endregion


        #region Strings
        const string THROTTLE = "Throttle";
        const string COLLECTIVE = "Collective";
        const string PEDAL = "Pedal";
        #endregion

        #region Custom methods

        protected override void HandleInputs()
        {
            base.HandleInputs();

            // input methods
            HandleThrottle();
            HandleCollective();
            HandleCyclic();
            HandlePedal();

            // utility methods
            ClampInputs();
            HandleStickyThrottle();
            HandleStickyCollective();
        }

        protected virtual void HandleThrottle()
        {
            _throttleInput = Input.GetAxis(THROTTLE);
        }
        protected virtual void HandleCollective()
        {
            _collectiveInput = Input.GetAxis(COLLECTIVE);
        }
        protected virtual void HandleCyclic()
        {
            _cyclicInput.y = vertical;
            _cyclicInput.x = horizontal;
        }
        protected virtual void HandlePedal()
        {
            _pedalInput = Input.GetAxis(PEDAL);
        }

        protected void ClampInputs()
        {
            _throttleInput = Mathf.Clamp(_throttleInput, -1f, 1f);
            _collectiveInput = Mathf.Clamp(_collectiveInput, -1f, 1f);
            _pedalInput = Mathf.Clamp(_pedalInput, -1f, 1f);
            _cyclicInput = Vector2.ClampMagnitude(_cyclicInput, 1f);
        }
        protected void HandleStickyThrottle()
        {
            _stickyThrottle += RawThrottleInput * Time.deltaTime;
            _stickyThrottle = Mathf.Clamp01(_stickyThrottle);
        }

        protected void HandleStickyCollective()
        {
            _stickyCollectiveInput += -CollectiveInput * Time.deltaTime;
            _stickyCollectiveInput = Mathf.Clamp01(_stickyCollectiveInput);
        }
        #endregion
    }
}
