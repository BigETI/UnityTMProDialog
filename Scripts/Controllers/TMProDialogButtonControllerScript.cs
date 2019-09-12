using TMPro;
using UnityDialog;
using UnityEngine;

/// <summary>
/// Unity TMPro dialog controllers namespace
/// </summary>
namespace UnityTMProDialog.Controllers
{
    /// <summary>
    /// TMPro dialog button controller script class
    /// </summary>
    public class TMProDialogButtonControllerScript : ADialogButtonControllerScript
    {
        /// <summary>
        /// Button text
        /// </summary>
        [SerializeField]
        private TextMeshProUGUI buttonText = default;

        /// <summary>
        /// Update text
        /// </summary>
        /// <param name="buttonText">Button text</param>
        protected override void UpdateText(string buttonText)
        {
            if (this.buttonText != null)
            {
                this.buttonText.text = buttonText;
            }
        }
    }
}
