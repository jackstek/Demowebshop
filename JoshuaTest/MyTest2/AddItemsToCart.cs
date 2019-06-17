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

namespace MyTest2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddItemsToCart recording.
    /// </summary>
    [TestModule("505fbd10-0a46-4e01-b5a0-228e38622f1b", ModuleType.Recording, 1)]
    public partial class AddItemsToCart : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest2Repository repository.
        /// </summary>
        public static MyTest2Repository repo = MyTest2Repository.Instance;

        static AddItemsToCart instance = new AddItemsToCart();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddItemsToCart()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddItemsToCart Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(0));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.AddToCart.Electronics'.", repo.ApplicationUnderTest.AddToCart.ElectronicsInfo, new RecordItemIndex(1));
            Validate.Exists(repo.ApplicationUnderTest.AddToCart.ElectronicsInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddToCart.Electronics' at Center.", repo.ApplicationUnderTest.AddToCart.ElectronicsInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.AddToCart.Electronics.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.AddToCart.CellPhones'.", repo.ApplicationUnderTest.AddToCart.CellPhonesInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ApplicationUnderTest.AddToCart.CellPhonesInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(4));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddToCart.CellPhones' at Center.", repo.ApplicationUnderTest.AddToCart.CellPhonesInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.AddToCart.CellPhones.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.AddToCart.SmartphoneAddtoCart'.", repo.ApplicationUnderTest.AddToCart.SmartphoneAddtoCartInfo, new RecordItemIndex(6));
            Validate.Exists(repo.ApplicationUnderTest.AddToCart.SmartphoneAddtoCartInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(7));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddToCart.SmartphoneAddtoCart' at Center.", repo.ApplicationUnderTest.AddToCart.SmartphoneAddtoCartInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.AddToCart.SmartphoneAddtoCart.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(9));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.AddToCart.ApparelShoes'.", repo.ApplicationUnderTest.AddToCart.ApparelShoesInfo, new RecordItemIndex(10));
            Validate.Exists(repo.ApplicationUnderTest.AddToCart.ApparelShoesInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddToCart.ApparelShoes' at Center.", repo.ApplicationUnderTest.AddToCart.ApparelShoesInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.AddToCart.ApparelShoes.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(12));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.AddToCart.BlueJeansAdd'.", repo.ApplicationUnderTest.AddToCart.BlueJeansAddInfo, new RecordItemIndex(13));
            Validate.Exists(repo.ApplicationUnderTest.AddToCart.BlueJeansAddInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddToCart.BlueJeansAdd' at Center.", repo.ApplicationUnderTest.AddToCart.BlueJeansAddInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.AddToCart.BlueJeansAdd.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}