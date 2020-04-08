
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Preferences;
using Android.Gms.Ads;

//using Android.Support.V4.


namespace Qurany
{
    [Activity(Label = "«⁄œ«œ« ", Icon = "@drawable/t_launcher", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class SettingActivity : Activity
    {
        ISharedPreferences setting;
        TextView tetviewCount;
        TextView tetviewstart;
        SeekBar sekbarCount;
        SeekBar sekbarStart;
        CheckBox cb;
        int chekStatus = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.setting1);
            sekbarCount = FindViewById<SeekBar>(Resource.Id.seekBarcounT);
            sekbarStart = FindViewById<SeekBar>(Resource.Id.seekBartimeS);
            tetviewCount = FindViewById<TextView>(Resource.Id.textViewcount);
            tetviewstart = FindViewById<TextView>(Resource.Id.textViewStrat);
            cb = FindViewById<CheckBox>(Resource.Id.checkBox1);
            setting = PreferenceManager.GetDefaultSharedPreferences(this);
            cb.CheckedChange += Ck_CheckedChange;
            sekbarCount.ProgressChanged += SekbarCount_ProgressChanged;
            sekbarStart.StopTrackingTouch += SekbarStart_StopTrackingTouch;

            //ads
            AdView mAdView = FindViewById<AdView>(Resource.Id.adView1);
            var adRequest = new AdRequest.Builder().Build();
            // Start loading the ad.
            mAdView.LoadAd(adRequest);

            // images =>

            ImageView imup1 = FindViewById<ImageView>(Resource.Id.ImageUp);
            ImageView imup2 = FindViewById<ImageView>(Resource.Id.ImageUpS);
            ImageView imdown1 = FindViewById<ImageView>(Resource.Id.ImageDown);
            ImageView imdown2 = FindViewById<ImageView>(Resource.Id.ImageDownS);

            // images clik events =>
            imup1.Click += delegate {
                if (sekbarCount.Progress < 6236)
                {
                    sekbarCount.Progress++;
                }
            };

            imup2.Click += delegate {
                if (sekbarStart.Progress < 5)
                {
                    sekbarStart.Progress++;
                    tetviewstart.Text = switchs(sekbarStart.Progress);
                    ISharedPreferencesEditor edit = setting.Edit();
                    edit.PutInt("start", sekbarStart.Progress);
                    edit.Apply();
                }
            };

            imdown1.Click += delegate {
                if (sekbarCount.Progress > 1)
                {
                    sekbarCount.Progress--;
                }
            };

            imdown2.Click += delegate
            {
                if (sekbarStart.Progress > 0)
                {
                    sekbarStart.Progress--;
                    tetviewstart.Text = switchs(sekbarStart.Progress);
                    ISharedPreferencesEditor edit = setting.Edit();
                    edit.PutInt("start", sekbarStart.Progress);
                    edit.Apply();
                }

            };

            // restor setting 
            int cou = setting.GetInt("count", 300);
            int pro = setting.GetInt("start", 0);

            sekbarCount.Progress = cou;
            tetviewCount.Text = sekbarCount.Progress.ToString();
            sekbarStart.Progress = pro;

            chekStatus = setting.GetInt("extra", 1);
            if (chekStatus == 1)
            {
                cb.Checked = true;
            }
            else
            {
                cb.Checked = false;
            }
            tetviewstart.Text = switchs(pro);
        }

        private void Ck_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {

            ISharedPreferencesEditor edit = setting.Edit();

            if (cb.Checked)
            {
                edit.PutInt("extra", 1);

            }
            else
            {
                edit.PutInt("extra", 0);

            }
            edit.Apply();
        }

        private void SekbarStart_StopTrackingTouch(object sender, SeekBar.StopTrackingTouchEventArgs e)
        {
            TextView textviewstart = FindViewById<TextView>(Resource.Id.textViewStrat);
            var sek = sender as SeekBar;
            int valu = sek.Progress;
            tetviewstart.Text = switchs(valu);
            ISharedPreferencesEditor edit = setting.Edit();
            edit.PutInt("start", valu);
            edit.Apply();
        }
        public string switchs(int valu)
        {
            string nam = "";
            switch (valu)
            {
                case 0:
                    nam = "«Ê· Õ—›";
                    break;
                case 1:
                    nam = "À«‰Ï Õ—›";
                    break;
                case 2:
                    nam = "À«·À Õ—›";
                    break;
                case 3:
                    nam = "—«»⁄ Õ—›";
                    break;
                case 4:
                    nam = "Œ«„” Õ—›";
                    break;
                case 5:
                    nam = "”«œ” Õ—›";
                    break;
                default:
                    break;
            }
            return nam;
        }
        private void SekbarCount_ProgressChanged(object sender, SeekBar.ProgressChangedEventArgs e)
        {
            var sek = sender as SeekBar;
            int valu = sek.Progress;
            if (valu == 0)
            {
                valu = 1;
            }
            tetviewCount.Text = valu.ToString();
            ISharedPreferencesEditor edit = setting.Edit();
            edit.PutInt("count", valu);
            edit.Apply();
        }
    }
}