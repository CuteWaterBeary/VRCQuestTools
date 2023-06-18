// <copyright file="UpdateCheckerAutomator.cs" company="kurotu">
// Copyright (c) kurotu.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
// </copyright>

using System;
using System.Threading.Tasks;
using KRT.VRCQuestTools.Models;
using KRT.VRCQuestTools.Views;
using UnityEditor;
using UnityEngine;

namespace KRT.VRCQuestTools.Automators
{
    /// <summary>
    /// Automatically check updates.
    /// </summary>
    [InitializeOnLoad]
    internal static class UpdateCheckerAutomator
    {
        private const int DelayDays = 1;

        static UpdateCheckerAutomator()
        {
            EditorApplication.delayCall += CheckForUpdates;
        }

        private static SemVer CurrentVersion => new SemVer(VRCQuestTools.Version);

        /// <summary>
        /// Check for updates.
        /// </summary>
        internal static void CheckForUpdates()
        {
            var instance = NotificationWindow.instance;
            var lastVersionCheckDate = VRCQuestToolsSettings.LastVersionCheckDateTime;
            var noNotificationDate = lastVersionCheckDate.AddDays(1);
            if (DateTime.Now < noNotificationDate)
            {
                Debug.Log($"[{VRCQuestTools.Name}] Version check is skipped until {noNotificationDate.ToLocalTime()}");
                return;
            }

        }
    }
}
