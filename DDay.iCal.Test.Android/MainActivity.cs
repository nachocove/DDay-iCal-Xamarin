using System.Reflection;
using Android.App;
using Android.OS;
using Xamarin.Android.NUnitLite;

namespace DDay.iCal.Test.Android
{
    [Activity (Label = "DDay.iCal.Test.Android", MainLauncher = true)]
    public class MainActivity : TestSuiteActivity
    {
        public static global::Android.Content.Res.AssetManager am = null;

        protected override void OnCreate (Bundle bundle)
        {
            am = this.Assets;
            // tests can be inside the main assembly
            AddTest (Assembly.GetExecutingAssembly ());
            // or in any reference assemblies
            // AddTest (typeof (Your.Library.TestClass).Assembly);

            // Once you called base.OnCreate(), you cannot add more assemblies.
            base.OnCreate (bundle);
        }
    }
}

