using System;

namespace RxCocoaSharp {
    public delegate void UpdateHandler(double currentTime);

    public interface IUpdateHandler {
        event UpdateHandler OnUpdate;
    }
}
