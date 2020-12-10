using System;
namespace RxCocoaSharp {
    public delegate void TextChangedHandler(string text);

    public interface ITextChangedHandler {
        event TextChangedHandler OnChangeText;
    }
}
