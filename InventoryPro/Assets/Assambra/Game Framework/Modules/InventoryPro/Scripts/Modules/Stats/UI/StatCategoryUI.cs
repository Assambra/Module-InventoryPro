using UnityEngine;
using System.Collections;
using Assambra.General;
using Assambra.General.UI;
using Assambra.InventoryPro;
using UnityEngine.UI;

namespace Assambra.InventoryPro.UI
{
    /// <summary>
    /// Used to define a category of stats.
    /// </summary>
    public partial class StatCategoryUI : MonoBehaviour, IPoolable
    {
        /// <summary>
        /// Name of the category
        /// </summary>
        [SerializeField]
        protected Text categoryName;

        [SerializeField]
        protected Button foldButton;

        [Required]
        public RectTransform container;

        public bool expandToParentSize = false;

        /// <summary>
        /// Check if the item is folded or not.
        /// </summary>
        protected bool isVisible = true;

        private LayoutElement containerLayoutElement;


        protected virtual void Awake()
        {
            containerLayoutElement = container.GetComponent<LayoutElement>();
            if (containerLayoutElement == null)
            {
                containerLayoutElement = container.gameObject.AddComponent<LayoutElement>();
            }

            if(foldButton != null)
            {
                foldButton.onClick.AddListener(OnFoldButtonClicked);
            }

            if (expandToParentSize)
            {
                UIUtility.InheritParentSize(transform);
            }
        }

        protected virtual void OnFoldButtonClicked()
        {
            isVisible = !isVisible;
            containerLayoutElement.gameObject.SetActive(isVisible);
        }

        public virtual void Repaint(string categoryName)
        {
            this.categoryName.text = categoryName;
        }

        public virtual void ResetStateForPool()
        {
            isVisible = true;
        }
    }
}