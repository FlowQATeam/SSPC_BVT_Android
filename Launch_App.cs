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
    ///The Launch_App recording.
    /// </summary>
    [TestModule("136b4c93-a94b-4c80-b8ab-e8b9d3bc7e7d", ModuleType.Recording, 1)]
    public partial class Launch_App : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SSPC_Android_BVTRepository repository.
        /// </summary>
        public static SSPC_Android_BVTRepository repo = SSPC_Android_BVTRepository.Instance;

        static Launch_App instance = new Launch_App();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Launch_App()
        {
            Endpoint = "Current Endpoint (None)";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Launch_App Instance
        {
            get { return instance; }
        }

#region Variables

        string _Endpoint;

        /// <summary>
        /// Gets or sets the value of variable Endpoint.
        /// </summary>
        [TestVariable("3299ec42-a326-4a86-b051-13fe5e25c42b")]
        public string Endpoint
        {
            get { return _Endpoint; }
            set { _Endpoint = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'com.pentair.pentairhome' on device " + Ranorex.Core.Remoting.RemoteServiceLocator.GetCurrentDeviceName() + ".", new RecordItemIndex(0));
            Host.Local.RunMobileApp(Endpoint, "com.pentair.pentairhome", false);
            Delay.Milliseconds(3500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch gestures", "Swipe gesture with direction 'Left (180°)' starting from 'Center' with distance '1.0' with swipe duration'500ms' and step count '0' on item 'ComPentairPentairhome.firstscreensipe'.", repo.ComPentairPentairhome.firstscreensipeInfo, new RecordItemIndex(2));
            repo.ComPentairPentairhome.firstscreensipe.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Left (180°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "1.0"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch gestures", "Swipe gesture with direction 'Left (180°)' starting from 'Center' with distance '1.0' with swipe duration'500ms' and step count '0' on item 'ComPentairPentairhome.SecondScreenSipe'.", repo.ComPentairPentairhome.SecondScreenSipeInfo, new RecordItemIndex(3));
            repo.ComPentairPentairhome.SecondScreenSipe.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Left (180°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "1.0"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch gestures", "Swipe gesture with direction 'Left (180°)' starting from 'Center' with distance '1.0' with swipe duration'500ms' and step count '0' on item 'ComPentairPentairhome.ThirdScreenSwipe'.", repo.ComPentairPentairhome.ThirdScreenSwipeInfo, new RecordItemIndex(4));
            repo.ComPentairPentairhome.ThirdScreenSwipe.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Left (180°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "1.0"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.LastScreen_Next_button' at Center", repo.ComPentairPentairhome.LastScreen_Next_buttonInfo, new RecordItemIndex(5));
            repo.ComPentairPentairhome.LastScreen_Next_button.Touch();
            Delay.Milliseconds(300);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
