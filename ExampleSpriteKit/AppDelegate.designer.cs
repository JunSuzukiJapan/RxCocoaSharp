﻿using Foundation;
using System.CodeDom.Compiler;

namespace ExampleSpriteKit {
    [Register("AppDelegate")]
    partial class AppDelegate {
        [Outlet]
        SpriteKit.SKView MyGameView { get; set; }

        void ReleaseDesignerOutlets() {
            if (MyGameView != null) {
                MyGameView.Dispose();
                MyGameView = null;
            }
        }
    }
}
