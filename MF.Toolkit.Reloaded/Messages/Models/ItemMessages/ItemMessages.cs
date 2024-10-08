﻿using MF.Toolkit.Interfaces.Messages.Models;

namespace MF.Toolkit.Reloaded.Messages.Models.ItemMessages;

internal class ItemMessages : IItemMessages
{
    private readonly Message name = new();
    private readonly Message desc = new();
    private readonly Message effect = new();

    public ItemMessages(string label)
    {
        name.Label = label;
        desc.Label = label;
        effect.Label = label;
    }

    public void SetName(string name) => this.name.Content = MsgUtils.WithWait(name);

    public void SetDescription(string description) => desc.Content = MsgUtils.WithWait(description);

    public void SetEffect(string effect) => this.effect.Content = MsgUtils.WithWait(effect);

    public (Message Name, Message Description, Message Effect) GetMessages() => (name, desc, effect);
}