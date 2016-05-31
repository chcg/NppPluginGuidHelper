﻿using System.Windows.Forms;
using Kbg.NppPluginNET.PluginInfrastructure;
using GuidHelper;

namespace Kbg.NppPluginNET
{
    class Main
    {
        internal const string PluginName = "&GuidHelper";

        public static void OnNotification(ScNotification notification)
        {  
            // This method is invoked whenever something is happening in notepad++
        }

        internal static void CommandMenuInit()
        {
            PluginBase.SetCommand(0, "&Insert Guid", InsertGuid, new ShortcutKey(false, false, false, Keys.None));
        }

        internal static void SetToolBarIcon()
        {
        }

        internal static void PluginCleanUp()
        {
        }

	    internal static void InsertGuid()
	    {
		    new InsertGuid(new ScintillaGateway(PluginBase.GetCurrentScintilla())).Execute();
	    }
    }
}