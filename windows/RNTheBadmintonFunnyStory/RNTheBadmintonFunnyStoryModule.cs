using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace The.Badminton.Funny.Story.RNTheBadmintonFunnyStory
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNTheBadmintonFunnyStoryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNTheBadmintonFunnyStoryModule"/>.
        /// </summary>
        internal RNTheBadmintonFunnyStoryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNTheBadmintonFunnyStory";
            }
        }
    }
}
