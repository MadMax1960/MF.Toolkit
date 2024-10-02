﻿namespace MF.Toolkit.Interfaces.Messages;

/// <summary>
/// MSG related functions and utils.
/// </summary>
public unsafe interface IMessage
{
    /// <summary>
    /// Create a MSG from a string (plaintext).
    /// </summary>
    /// <param name="str">String.</param>
    /// <returns>MSG object pointer.</returns>
    MSG* CreateMsg(string str);

    /// <summary>
    /// Create a MSG from a string (plaintext) with specific settings.
    /// </summary>
    /// <param name="str">String.</param>
    /// <param name="flags">MSG flags.</param>
    /// <param name="config1">MSG config 1.</param>
    /// <param name="config2">MSG config 2.</param>
    /// <returns>MSG object pointer.</returns>
    MSG* CreateMsg(string str, MsgFlags flags, MsgConfig1 config1, MsgConfig2 config2);

    /// <summary>
    /// Set text for an item.
    /// </summary>
    /// <param name="itemId">Item ID of item to set text of.</param>
    /// <param name="type">The type of text.</param>
    /// <param name="text">The text to set.</param>
    void SetItemText(int itemId, ItemText type, string text);
}
