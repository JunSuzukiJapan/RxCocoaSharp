# RxCocoaSharp

Reactive Extensions for Cocoa on Xamarin C#.

# Usage

## Step 1

Add require library ```RxCocoaSharp``` and ```System.Reactive.Linq``` to your project.

## Step 2

Add using clauses.

```
using System.Reactive.Linq;
using RxCocoaSharp;
```

## Step 3

Change class from ```NS***``` to ```RxNS***```,
or from ```SK***``` to ```RxSK***```.

example:

```
public class GameScene : SKScene {
```

to

```
public class GameScene : RxSKScene {
```

# Example

```
using System;
using SpriteKit;
using Foundation;
using CoreGraphics;

using System.Reactive.Linq;
using RxCocoaSharp;

namespace ExampleSpriteKit {
    public class GameScene : RxSKScene {
        public GameScene(IntPtr handle) : base(handle) {
        }

        public override void DidMoveToView(SKView view) {
            this.ObservableMouseClick()
                .Subscribe(e => {
                     Console.WriteLine("View clicked");
                     CreateSprite(e.LocationInNode(this));
                 });
        }

        public void CreateSprite(CGPoint location) {
            var sprite = SKSpriteNode.FromImageNamed(NSBundle.MainBundle.PathForResource("Spaceship", "png"));

            sprite.Position = location;
            sprite.SetScale(0.5f);

            var action = SKAction.RotateByAngle(NMath.PI, 1.0);

            sprite.RunAction(SKAction.RepeatActionForever(action));

            AddChild(sprite);
        }
    }
}
```

# Appendix

## Classes

|Original|RxCocoaSharp|
---|---
|NSButton|RxNSButton  |
|NSSlider|RxNSSlider  |
|NSTextField|RxNSTextField|
|NSTextView|RxNSTextView|
|NSWindow|RxNSWindow|
|SKCropNode|RxSKCropNode|
|SKEffectNode|RxSKEffectNode|
|SKLabelNode|RxSKLabelNode|
|SKNode|RxSKNode|
|SKScene|RxSKScene|
|SKShapeNode|RxSKShapeNode|
|SKSpriteNode|RxSKSpriteNode|
|SKVideoNode|RxSKVideoNode|
|SKView|RxSKView|

## Observables

### All Rx** class

- ObservableClick
- ObservableKeyDown
- ObservableMouseClick
- ObservableRightMouseClick
- ObservableOtherMouseClick
- ObservableMouseDragged
- ObservableRightMouseDragged
- ObservableOtherMouseDragged

### RxSKScene Only

- ObservableUpdate

### RxNSTextField & RxNSTextView

- ObservableDidTextChange
