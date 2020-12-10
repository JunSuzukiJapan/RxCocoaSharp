using System;

namespace RxCocoaSharp {
    public interface IOnClickHandler {
        event Action OnClick;
    }
}
