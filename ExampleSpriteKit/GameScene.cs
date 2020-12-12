using System;

using AppKit;
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
            // Setup your scene here
            RxSKLabelNode myLabel = RxSKLabelNode.FromFont("Chalkduster");

            myLabel.Text = "Hello, World!";
            myLabel.FontSize = 65;
            myLabel.Position = new CGPoint(Frame.GetMidX(), Frame.GetMidY());
            myLabel.UserInteractionEnabled = true;

            AddChild(myLabel);

            myLabel.ObservableMouseClick()
                  .Subscribe(e => Console.WriteLine("Label Clicked!"));

            RxNSButton myButton = new RxNSButton();

            myButton.Title = "Hello, World!";
            myButton.Frame = new CGRect(0, 0, 50, 30);
            this.View.AddSubview(myButton);
            myButton.ObservableClick()
                  .Subscribe(e => Console.WriteLine("Button Clicked!"));


            this.ObservableKeyDown()
                .Subscribe(e => Console.WriteLine("chrs: {0}", e.Characters));

            this.ObservableMouseClick()
                  //.Subscribe(e => Console.WriteLine("GameScene Clicked!"));
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
