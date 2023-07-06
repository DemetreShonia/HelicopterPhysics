using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shonia
{
    public class BaseHeliInput : MonoBehaviour
    {
        #region Variables
        [Header("Base Input Properties")]
        protected float vertical = 0f;
        protected float horizontal = 0f;

        #region Strings
        const string VERTICAL = "Vertical";
        const string HORIZONTAL = "Horizontal";
        #endregion

        #endregion

        #region BuiltIn Methods
        void Update()
        {
            HandleInputs();
        }
        #endregion
        #region Custom Methods
        protected virtual void HandleInputs()
        {
            vertical = Input.GetAxis(VERTICAL);
            horizontal = Input.GetAxis(HORIZONTAL);
        }
        #endregion
    }
}
