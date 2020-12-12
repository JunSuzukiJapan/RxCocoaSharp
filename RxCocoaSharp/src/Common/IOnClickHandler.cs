using System;

namespace RxCocoaSharp {
    public interface IOnClickHandler {
        event NSEventHandler OnClick;
    }
}
