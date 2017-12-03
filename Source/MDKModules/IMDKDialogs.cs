﻿using System;

namespace Malware.MDKModules
{
    /// <summary>
    /// Utilities to show common dialogs
    /// </summary>
    public interface IMDKDialogs
    {
        /// <summary>
        /// Shows an error dialog.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="exception"></param>
        void ShowError(string title, string description, Exception exception);

        /// <summary>
        /// Shows a simple message box.
        /// </summary>
        /// <param name="title">The message box title</param>
        /// <param name="description">A description</param>
        /// <param name="type">The message type</param>
        /// <returns>The response to the message</returns>
        MessageResponse ShowMessage(string title, string description, MessageType type);

        /// <summary>
        /// Shows a dialog to select (or just manage) blueprints.
        /// </summary>
        /// <param name="projectOptions">The project options containing the required paths</param>
        /// <param name="customDescription">An optional custom description</param>
        /// <returns>Information about the selected blueprint. May be <see cref="BlueprintInfo.Empty"/></returns>
        BlueprintInfo ShowBlueprintDialog(MDKProjectOptions projectOptions, string customDescription = null);
    }
}