using System;
using System.Reactive.Linq;
using AppKit;
using Foundation;
using SpriteKit;

namespace RxCocoaSharp {
    public class RxSKLabelNode : SKLabelNode, IEventHandler {
        public event NSEventHandler OnKeyDown;
        public event NSEventHandler OnKeyUp;
        public event NSEventHandler OnMouseDown;
        public event NSEventHandler OnMouseUp;
        public event NSEventHandler OnMouseMoved;
        public event NSEventHandler OnMouseDragged;
        public event NSEventHandler OnMouseEntered;
        public event NSEventHandler OnMouseExited;
        public event NSEventHandler OnRightMouseDown;
        public event NSEventHandler OnRightMouseUp;
        public event NSEventHandler OnRightMouseDragged;
        public event NSEventHandler OnOtherMouseDown;
        public event NSEventHandler OnOtherMouseUp;
        public event NSEventHandler OnOtherMouseDragged;
        public event NSEventHandler OnScrollWheel;
        public event NSEventHandler OnTabletPoint;
        public event NSEventHandler OnTabletProximity;
        public event NSEventHandler OnBeginGestureWithEvent;
        public event NSEventHandler OnEndGestureWithEvent;
        public event NSEventHandler OnMagnifyWithEvent;
        public event NSEventHandler OnSmartMagnify;
        public event NSEventHandler OnSwipeWithEvent;
        public event NSEventHandler OnRotateWithEvent;
        public event NSEventHandler OnPressureChange;
        public event NSEventHandler OnTouchesBeganWithEvent;
        public event NSEventHandler OnTouchesEndedWithEvent;
        public event NSEventHandler OnTouchesCancelledWithEvent;
        public event NSEventHandler OnTouchesMovedWithEvent;
        public event NSEventHandler OnQuickLook;
        public event NSEventHandler OnFlagsChanged;
        public event NSEventHandler OnChangeMode;

        public RxSKLabelNode() : base() { }
        public RxSKLabelNode(string fontName) : base(fontName) {}

        public static new RxSKLabelNode FromFont(string fontName) {
            var node = new RxSKLabelNode(fontName);
            return node;
        }

        public static new RxSKLabelNode FromText(string text){
            var node = new RxSKLabelNode();
            node.Text = text;
            return node;
        }

        public static new RxSKLabelNode FromText(NSAttributedString attrText) {
            var node = new RxSKLabelNode();
            node.AttributedText = attrText;
            return node;
        }

        public override void MouseDown(NSEvent theEvent) {
            base.MouseDown(theEvent);
            if (OnMouseDown != null) {
                OnMouseDown(theEvent);
            }
        }

        public override void MouseUp(NSEvent theEvent) {
            base.MouseUp(theEvent);
            if (OnMouseUp != null) {
                OnMouseUp(theEvent);
            }
        }

        public override void MouseMoved(NSEvent theEvent) {
            base.MouseMoved(theEvent);
            if (OnMouseMoved != null) {
                OnMouseMoved(theEvent);
            }
        }

        public override void MouseDragged(NSEvent theEvent) {
            base.MouseDragged(theEvent);
            if (OnMouseDragged != null) {
                OnMouseDragged(theEvent);
            }
        }

        public override void MouseEntered(NSEvent theEvent) {
            base.MouseEntered(theEvent);
            if (OnMouseEntered != null) {
                OnMouseEntered(theEvent);
            }
        }

        public override void MouseExited(NSEvent theEvent) {
            base.MouseExited(theEvent);
            if (OnMouseExited != null) {
                OnMouseExited(theEvent);
            }
        }

        public override void RightMouseDown(NSEvent theEvent) {
            base.RightMouseDown(theEvent);
            if (OnRightMouseDown != null) {
                OnRightMouseDown(theEvent);
            }
        }

        public override void RightMouseUp(NSEvent theEvent) {
            base.RightMouseUp(theEvent);
            if (OnRightMouseUp != null) {
                OnRightMouseUp(theEvent);
            }
        }

        public override void RightMouseDragged(NSEvent theEvent) {
            base.RightMouseDragged(theEvent);
            if (OnRightMouseDragged != null) {
                OnRightMouseDragged(theEvent);
            }
        }

        public override void OtherMouseDown(NSEvent theEvent) {
            base.OtherMouseDown(theEvent);
            if (OnOtherMouseDown != null) {
                OnOtherMouseDown(theEvent);
            }
        }

        public override void OtherMouseUp(NSEvent theEvent) {
            base.OtherMouseUp(theEvent);
            if (OnOtherMouseUp != null) {
                OnOtherMouseUp(theEvent);
            }
        }

        public override void OtherMouseDragged(NSEvent theEvent) {
            base.OtherMouseDragged(theEvent);
            if (OnOtherMouseDragged != null) {
                OnOtherMouseDragged(theEvent);
            }
        }

        public override void KeyDown(NSEvent theEvent) {
            //base.KeyDown(theEvent);  // ピッというキー入力音が鳴るのでコメントアウト
            if (OnKeyDown != null) {
                OnKeyDown(theEvent);
            }
        }

        public override void KeyUp(NSEvent theEvent) {
            base.KeyUp(theEvent);
            if (OnKeyUp != null) {
                OnKeyUp(theEvent);
            }
        }

        public override void ScrollWheel(NSEvent theEvent) {
            base.ScrollWheel(theEvent);
            if (OnScrollWheel != null) {
                OnScrollWheel(theEvent);
            }
        }

        public override void TabletPoint(NSEvent theEvent) {
            base.TabletPoint(theEvent);
            if (OnTabletPoint != null) {
                OnTabletPoint(theEvent);
            }
        }

        public override void TabletProximity(NSEvent theEvent) {
            base.TabletProximity(theEvent);
            if (OnTabletProximity != null) {
                OnTabletProximity(theEvent);
            }
        }

        public override void BeginGestureWithEvent(NSEvent theEvent) {
            base.BeginGestureWithEvent(theEvent);
            if (OnBeginGestureWithEvent != null) {
                OnBeginGestureWithEvent(theEvent);
            }
        }

        public override void EndGestureWithEvent(NSEvent theEvent) {
            base.EndGestureWithEvent(theEvent);
            if (OnEndGestureWithEvent != null) {
                OnEndGestureWithEvent(theEvent);
            }
        }

        public override void MagnifyWithEvent(NSEvent theEvent) {
            base.MagnifyWithEvent(theEvent);
            if (OnMagnifyWithEvent != null) {
                OnMagnifyWithEvent(theEvent);
            }
        }

        public override void SmartMagnify(NSEvent withEvent) {
            base.SmartMagnify(withEvent);
            if (OnSmartMagnify != null) {
                OnSmartMagnify(withEvent);
            }
        }

        public override void SwipeWithEvent(NSEvent theEvent) {
            base.SwipeWithEvent(theEvent);
            if (OnSwipeWithEvent != null) {
                OnSwipeWithEvent(theEvent);
            }
        }

        public override void RotateWithEvent(NSEvent theEvent) {
            base.RotateWithEvent(theEvent);
            if (OnRotateWithEvent != null) {
                OnRotateWithEvent(theEvent);
            }
        }

        public override void PressureChange(NSEvent pressureChangeEvent) {
            base.PressureChange(pressureChangeEvent);
            if (OnPressureChange != null) {
                OnPressureChange(pressureChangeEvent);
            }
        }

        public override void TouchesBeganWithEvent(NSEvent theEvent) {
            base.TouchesBeganWithEvent(theEvent);
            if (OnTouchesBeganWithEvent != null) {
                OnTouchesBeganWithEvent(theEvent);
            }
        }

        public override void TouchesEndedWithEvent(NSEvent theEvent) {
            base.TouchesEndedWithEvent(theEvent);
            if (OnTouchesEndedWithEvent != null) {
                OnTouchesEndedWithEvent(theEvent);
            }
        }

        public override void TouchesCancelledWithEvent(NSEvent theEvent) {
            base.TouchesCancelledWithEvent(theEvent);
            if (OnTouchesCancelledWithEvent != null) {
                OnTouchesCancelledWithEvent(theEvent);
            }
        }

        public override void TouchesMovedWithEvent(NSEvent theEvent) {
            base.TouchesMovedWithEvent(theEvent);
            if (OnTouchesMovedWithEvent != null) {
                OnTouchesMovedWithEvent(theEvent);
            }
        }

        public override void QuickLook(NSEvent withEvent) {
            base.QuickLook(withEvent);
            if (OnQuickLook != null) {
                OnQuickLook(withEvent);
            }
        }

        public override void FlagsChanged(NSEvent theEvent) {
            base.FlagsChanged(theEvent);
            if (OnFlagsChanged != null) {
                OnFlagsChanged(theEvent);
            }
        }

        public override void ChangeMode(NSEvent withEvent) {
            base.ChangeMode(withEvent);
            if (OnChangeMode != null) {
                OnChangeMode(withEvent);
            }
        }
    }
}
