using Bloatynosy;
using System.Threading.Tasks;

namespace Features.Feature
{
    public abstract class FeatureBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;
        public string ScriptFilePath { get; set; } // Path to Powershell plugins directory

        /// <summary>
        /// Name of Feature
        /// </summary>
        /// <returns>The feature name</returns>
        public abstract string ID();

        /// <summary>
        /// Description of Feature
        /// </summary>
        /// <returns>The feature tooltip</returns>
        public abstract string Info();

        /// <summary>
        /// Checks whether Features should be applied
        /// </summary>
        /// <returns>Returns true if the feature should be applied, false otherwise.</returns>
        public abstract bool CheckFeature();

        /// <summary>
        /// Do the Feature
        /// </summary>
        /// <returns>Returns true if the feature was successfull, false otherwise.</returns>
        public abstract bool DoFeature();

        /// <summary>
        /// Undo the Feature
        /// </summary>
        /// <returns>Returns true if the feature was successfull, false otherwise.</returns>
        public abstract bool UndoFeature();

        public virtual bool LoadScriptFile()
        {
            // Check if the script file path is set for the feature
            if (!string.IsNullOrEmpty(ScriptFilePath))
            {
            }

            return false; // Return false if no script file path is set for the feature
        }
    }
}