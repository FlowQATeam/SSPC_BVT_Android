///////////////////////////////////////////////////////////////////////////////
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
    ///The analytics recording.
    /// </summary>
    [TestModule("1d93cd4e-f8cc-4c6f-a34b-0c52e05ca3fc", ModuleType.Recording, 1)]
    public partial class analytics : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SSPC_Android_BVTRepository repository.
        /// </summary>
        public static SSPC_Android_BVTRepository repo = SSPC_Android_BVTRepository.Instance;

        static analytics instance = new analytics();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public analytics()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static analytics Instance
        {
            get { return instance; }
        }

#region Variables

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
            
            Report.Log(ReportLevel.Info, "Touch gestures", "Swipe gesture with direction 'Up (270°)' starting from 'Center' with distance '200' with swipe duration'500ms' and step count '0' on item 'ComPentairPentairhome.ProductOverview'.", repo.ComPentairPentairhome.ProductOverviewInfo, new RecordItemIndex(6));
            repo.ComPentairPentairhome.ProductOverview.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "200"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(7));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Analytics' at Center", repo.ComPentairPentairhome.AnalyticsInfo, new RecordItemIndex(8));
            repo.ComPentairPentairhome.Analytics.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ComPentairPentairhome.UIWindow.ScreenShot, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.WeeklyAnalytics' at Center", repo.ComPentairPentairhome.WeeklyAnalyticsInfo, new RecordItemIndex(11));
            repo.ComPentairPentairhome.WeeklyAnalytics.Touch();
            Delay.Milliseconds(300);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(12));
            //Delay.Duration(2000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ComPentairPentairhome.UIWindow.ScreenShot, false, new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ContactPentairBack' at Center", repo.ComPentairPentairhome.ContactPentairBackInfo, new RecordItemIndex(14));
            repo.ComPentairPentairhome.ContactPentairBack.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(15));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Analytics' at Center", repo.ComPentairPentairhome.AnalyticsInfo, new RecordItemIndex(16));
            repo.ComPentairPentairhome.Analytics.Touch();
            Delay.Milliseconds(300);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(17));
            //Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.QuarterlyAnalytics' at Center", repo.ComPentairPentairhome.QuarterlyAnalyticsInfo, new RecordItemIndex(18));
            repo.ComPentairPentairhome.QuarterlyAnalytics.Touch();
            Delay.Milliseconds(300);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(19));
            //Delay.Duration(2000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ComPentairPentairhome.UIWindow.ScreenShot, false, new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ContactPentairBack' at Center", repo.ComPentairPentairhome.ContactPentairBackInfo, new RecordItemIndex(21));
            repo.ComPentairPentairhome.ContactPentairBack.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(22));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Analytics' at Center", repo.ComPentairPentairhome.AnalyticsInfo, new RecordItemIndex(23));
            repo.ComPentairPentairhome.Analytics.Touch();
            Delay.Milliseconds(300);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(24));
            //Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.DaillyAnalytics' at Center", repo.ComPentairPentairhome.DaillyAnalyticsInfo, new RecordItemIndex(25));
            repo.ComPentairPentairhome.DaillyAnalytics.Touch();
            Delay.Milliseconds(300);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(26));
            //Delay.Duration(2000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ComPentairPentairhome.UIWindow.ScreenShot, false, new RecordItemIndex(27));
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.ContactPentairBack' at Center", repo.ComPentairPentairhome.ContactPentairBackInfo, new RecordItemIndex(28));
            repo.ComPentairPentairhome.ContactPentairBack.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(29));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Analytics' at Center", repo.ComPentairPentairhome.AnalyticsInfo, new RecordItemIndex(30));
            repo.ComPentairPentairhome.Analytics.Touch();
            Delay.Milliseconds(300);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(31));
            //Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.MonthlyAnalytics' at Center", repo.ComPentairPentairhome.MonthlyAnalyticsInfo, new RecordItemIndex(32));
            repo.ComPentairPentairhome.MonthlyAnalytics.Touch();
            Delay.Milliseconds(300);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ComPentairPentairhome.UIWindow.ScreenShot, false, new RecordItemIndex(33));
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(34));
            //Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
