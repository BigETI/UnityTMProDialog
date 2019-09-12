using TMPro;
using UnityDialog;
using UnityEngine;

/// <summary>
/// Unity TMPro dialog controllers namespace
/// </summary>
namespace UnityTMProDialog.Controllers
{
    /// <summary>
    /// TMPro dialog UI controller script class
    /// </summary>
    public class TMProDialogUIControllerScript : ADialogUIControllerScript
    {
        /// <summary>
        /// Title text
        /// </summary>
        [SerializeField]
        private TextMeshProUGUI titleText = default;

        /// <summary>
        /// Message text
        /// </summary>
        [SerializeField]
        private TextMeshProUGUI messageText = default;

        /// <summary>
        /// Update text
        /// </summary>
        /// <param name="titleText">Title text</param>
        /// <param name="titleTextColor">Title text color</param>
        /// <param name="messageText">Message text</param>
        protected override void UpdateText(string titleText, Color titleTextColor, string messageText)
        {
            if (this.titleText != null)
            {
                this.titleText.text = titleText;
                this.titleText.color = titleTextColor;
            }
            if (this.messageText != null)
            {
                this.messageText.text = messageText;
            }
        }
    }
}
