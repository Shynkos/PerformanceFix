﻿#nullable enable

namespace Uno.UI.RemoteControl.Messaging.IdeChannel;

public record KeepAliveIdeMessage() : IdeMessage(WellKnownScopes.IdeChannel);
