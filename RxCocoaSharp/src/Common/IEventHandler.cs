using System;
using AppKit;

namespace RxCocoaSharp {
    public delegate void NSEventHandler(NSEvent theEvent);

    public interface IEventHandler {
        event NSEventHandler OnKeyDown;
        event NSEventHandler OnKeyUp;
        event NSEventHandler OnMouseDown;
        event NSEventHandler OnMouseUp;
        event NSEventHandler OnMouseMoved;
        event NSEventHandler OnMouseDragged;
        event NSEventHandler OnMouseEntered;
        event NSEventHandler OnMouseExited;
        event NSEventHandler OnRightMouseDown;
        event NSEventHandler OnRightMouseUp;
        event NSEventHandler OnRightMouseDragged;
        event NSEventHandler OnOtherMouseDown;
        event NSEventHandler OnOtherMouseUp;
        event NSEventHandler OnOtherMouseDragged;
        event NSEventHandler OnScrollWheel;
        event NSEventHandler OnTabletPoint;
        event NSEventHandler OnTabletProximity;
        event NSEventHandler OnBeginGestureWithEvent;
        event NSEventHandler OnEndGestureWithEvent;
        event NSEventHandler OnMagnifyWithEvent;
        event NSEventHandler OnSmartMagnify;
        event NSEventHandler OnSwipeWithEvent;
        event NSEventHandler OnRotateWithEvent;
        event NSEventHandler OnPressureChange;
        event NSEventHandler OnTouchesBeganWithEvent;
        event NSEventHandler OnTouchesEndedWithEvent;
        event NSEventHandler OnTouchesCancelledWithEvent;
        event NSEventHandler OnTouchesMovedWithEvent;
        event NSEventHandler OnQuickLook;
        event NSEventHandler OnFlagsChanged;
        event NSEventHandler OnChangeMode;
    }
}
