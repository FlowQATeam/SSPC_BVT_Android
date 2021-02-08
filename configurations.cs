﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SSPC_iOS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The configurations recording.
    /// </summary>
    [TestModule("c11a2f29-76fc-4d23-af9c-693c3599c6be", ModuleType.Recording, 1)]
    public partial class configurations : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SSPC_Android_BVTRepository repository.
        /// </summary>
        public static SSPC_Android_BVTRepository repo = SSPC_Android_BVTRepository.Instance;

        static configurations instance = new configurations();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public configurations()
        {
            DryRunInput = "10";
            ExtraRunTimeInput = "2";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static configurations Instance
        {
            get { return instance; }
        }

#region Variables

        string _DryRunInput;

        /// <summary>
        /// Gets or sets the value of variable DryRunInput.
        /// </summary>
        [TestVariable("7e5bb548-09e9-4504-879f-f6b2eed7e978")]
        public string DryRunInput
        {
            get { return _DryRunInput; }
            set { _DryRunInput = value; }
        }

        string _ExtraRunTimeInput;

        /// <summary>
        /// Gets or sets the value of variable ExtraRunTimeInput.
        /// </summary>
        [TestVariable("1e85eb39-8f9f-4aa5-b419-f9605743f1e1")]
        public string ExtraRunTimeInput
        {
            get { return _ExtraRunTimeInput; }
            set { _ExtraRunTimeInput = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Nickname.
        /// </summary>
        [TestVariable("15db34cc-b901-4dc4-b385-f561e02f4c65")]
        public string Nickname
        {
            get { return repo.Nickname; }
            set { repo.Nickname = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.HomeIcon' at Center", repo.ComPentairPentairhome.HomeIconInfo, new RecordItemIndex(0));
            repo.ComPentairPentairhome.HomeIcon.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.SSPCtileClick' at Center", repo.ComPentairPentairhome.SSPCtileClickInfo, new RecordItemIndex(2));
            repo.ComPentairPentairhome.SSPCtileClick.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(3));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Settingsicon' at Center", repo.ComPentairPentairhome.SettingsiconInfo, new RecordItemIndex(4));
            repo.ComPentairPentairhome.Settingsicon.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(5));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Configurations' at Center", repo.ComPentairPentairhome.ConfigurationsInfo, new RecordItemIndex(6));
            repo.ComPentairPentairhome.Configurations.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(7));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.DryRunToggle' at Center", repo.ComPentairPentairhome.DryRunToggleInfo, new RecordItemIndex(8));
            repo.ComPentairPentairhome.DryRunToggle.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(9));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$DryRunInput' on item 'ComPentairPentairhome.DryRunInput'.", repo.ComPentairPentairhome.DryRunInputInfo, new RecordItemIndex(10));
            repo.ComPentairPentairhome.DryRunInput.Element.SetAttributeValue("Text", DryRunInput);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(11));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.DryRunHelp' at Center", repo.ComPentairPentairhome.DryRunHelpInfo, new RecordItemIndex(12));
            repo.ComPentairPentairhome.DryRunHelp.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(13));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ConfiguratioonsOK' at Center", repo.ComPentairPentairhome.ConfiguratioonsOKInfo, new RecordItemIndex(14));
            repo.ComPentairPentairhome.ConfiguratioonsOK.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(15));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$ExtraRunTimeInput' on item 'ComPentairPentairhome.ExtraRunTimeInput'.", repo.ComPentairPentairhome.ExtraRunTimeInputInfo, new RecordItemIndex(16));
            repo.ComPentairPentairhome.ExtraRunTimeInput.Element.SetAttributeValue("Text", ExtraRunTimeInput);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(17));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ExtraRuntimeHelp' at Center", repo.ComPentairPentairhome.ExtraRuntimeHelpInfo, new RecordItemIndex(18));
            repo.ComPentairPentairhome.ExtraRuntimeHelp.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(19));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Touch() on item 'ComPentairPentairhome.ConfiguratioonsOK'.", repo.ComPentairPentairhome.ConfiguratioonsOKInfo, new RecordItemIndex(20));
            repo.ComPentairPentairhome.ConfiguratioonsOK.Element.InvokeActionWithText("Touch");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(21));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
