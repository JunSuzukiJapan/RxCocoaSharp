using System;
namespace RxCocoaSharp {
    public delegate void DoubleValueChangeHandler(double value);

    public interface IDoubleValueChangeHandler {
        event DoubleValueChangeHandler OnDoubleValueChanged;
    }
}
