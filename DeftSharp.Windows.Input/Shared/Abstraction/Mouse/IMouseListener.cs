﻿using System;
using System.Collections.Generic;
using DeftSharp.Windows.Input.Mouse;
using DeftSharp.Windows.Input.Shared.Subscriptions;

namespace DeftSharp.Windows.Input.Shared.Abstraction.Mouse;

internal interface IMouseListener : IDisposable
{
    IEnumerable<MouseSubscription> Subscriptions { get; }
    
    Coordinates GetPosition();

    MouseSubscription Subscribe(MouseEvent mouseEvent, Action onAction, TimeSpan intervalOfClick);
    MouseSubscription SubscribeOnce(MouseEvent mouseEvent, Action onAction);

    void Unsubscribe(MouseEvent mouseEvent);
    void Unsubscribe(Guid id);
    void UnsubscribeAll();
}