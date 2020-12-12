using System;
using System.Reactive.Linq;
using AppKit;

namespace RxCocoaSharp {
    public static class NSEventObservable {
        public static IObservable<string> ObservableDidTextChange(this ITextChangedHandler scene) =>
            Observable.FromEvent<TextChangedHandler, string>(
                h => (s) => h(s),
                h => scene.OnChangeText += h,
                h => scene.OnChangeText -= h);

        public static IObservable<double> ObservableUpdate(this IUpdateHandler scene) =>
            Observable.FromEvent<UpdateHandler, double>(
                h => (d) => h(d),
                h => scene.OnUpdate += h,
                h => scene.OnUpdate -= h);

        public static IObservable<NSEvent> ObservableClick(this IOnClickHandler btn) =>
            Observable.FromEvent<NSEventHandler, NSEvent>(
                h => (e) => h(e),
                h => btn.OnClick += h,
                h => btn.OnClick -= h);

        public static IObservable<NSEvent> ObservableKeyDown(this IEventHandler scene) =>
            Observable.FromEvent<NSEventHandler, NSEvent>(
                h => (e) => h(e),
                h => scene.OnKeyDown += h,
                h => scene.OnKeyDown -= h);

        public static IObservable<NSEvent> ObservableMouseClick(this IEventHandler scene) =>
            Observable.FromEvent<NSEventHandler, NSEvent>(
                h => (e) => h(e),
                h => scene.OnMouseDown += h,
                h => scene.OnMouseDown -= h);

        public static IObservable<NSEvent> ObservableRightMouseClick(this IEventHandler scene) =>
            Observable.FromEvent<NSEventHandler, NSEvent>(
                h => (e) => h(e),
                h => scene.OnRightMouseDown += h,
                h => scene.OnRightMouseDown -= h);

        public static IObservable<NSEvent> ObservableOtherMouseClick(this IEventHandler scene) =>
            Observable.FromEvent<NSEventHandler, NSEvent>(
                h => (e) => h(e),
                h => scene.OnOtherMouseDown += h,
                h => scene.OnOtherMouseDown -= h);

        public static IObservable<NSEvent> ObservableMouseDragged(this IEventHandler scene) =>
            Observable.FromEvent<NSEventHandler, NSEvent>(
                h => (e) => h(e),
                h => scene.OnMouseDragged += h,
                h => scene.OnMouseDragged -= h);

        public static IObservable<NSEvent> ObservableRightMouseDragged(this IEventHandler scene) =>
            Observable.FromEvent<NSEventHandler, NSEvent>(
                h => (e) => h(e),
                h => scene.OnRightMouseDragged += h,
                h => scene.OnRightMouseDragged -= h);

        public static IObservable<NSEvent> ObservableOtherMouseDragged(this IEventHandler scene) =>
            Observable.FromEvent<NSEventHandler, NSEvent>(
                h => (e) => h(e),
                h => scene.OnOtherMouseDragged += h,
                h => scene.OnOtherMouseDragged -= h);

    }
}
