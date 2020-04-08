using System;
using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Preferences;
using Android.Gms.AppInvite;
using Android.Support.V4.Content;
using Android.Gms.Common.Apis;
using System.Threading.Tasks;
using Android.Util;

namespace Qurany
{
    [Activity(Label = "آَيَة", MainLauncher = true, Icon = "@drawable/ico")]
    public class MainActivity : Activity
    {
        // app invite
        const string TAG = "APPINVITES";
        const int REQUEST_INVITE = 101;
        const int RESOLUTION_CODE = 102;

        LocalBroadcastReceiver deepLinkReceiver;
        GoogleApiClient googleApiClient;

        Quran quran = new Quran();
        EditText input;
        ListView lv;
        List<string> ayayt;
        TextView tv;

        //setting
        ISharedPreferences setting;
        int count, start, extra;
        void SendInvite()
        {
            try
            {
                Intent intent = new Intent(Intent.ActionMain);
                intent.AddCategory(Intent.CategoryAppEmail);
                //intent.addCategory(Intent.CATEGORY_APP_EMAIL);
                StartActivity(intent);
                StartActivity(Intent.CreateChooser(intent, GetString(Resource.String.Hello)));
            }
            catch
            {


            }

        }



        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            setting = PreferenceManager.GetDefaultSharedPreferences(this);
            tv = FindViewById<TextView>(Resource.Id.textView1);
            lv = FindViewById<ListView>(Resource.Id.listView1);
            start = setting.GetInt("start", 0);
            count = setting.GetInt("count", 300);
            extra = setting.GetInt("extra", 1);
            // tv.Text = start.ToString();
            input = FindViewById<EditText>(Resource.Id.editText1);

            input.TextChanged += Input_TextChanged;


            // app invite
            googleApiClient = new GoogleApiClient.Builder(this)
             .AddApi(AppInviteClass.API)
             .AddConnectionCallbacks(async info => {

                 if (AppInviteReferral.HasReferral(Intent))
                     await UpdateInvitationStatus(Intent);

             }, cause => Console.WriteLine("Connection Suspended: {0}", cause))
             .AddOnConnectionFailedListener(result => {

                 if (!result.IsSuccess)
                 {
                     if (result.HasResolution)
                         result.StartResolutionForResult(this, RESOLUTION_CODE);
                     else
                         Toast.MakeText(this, "Failed to Connect: " + result.ErrorCode, ToastLength.Long).Show();
                 }
             })
             .Build();

            // If the app was already installed and the appinvite was opened
            // we may have information passed in about it here
            if (bundle == null)
            {
                // No savedInstanceState, so it is the first launch of this activity

                if (AppInviteReferral.HasReferral(Intent))
                {
                    // In this case the referral data is in the intent launching the MainActivity,
                    // which means this user already had the app installed. We do not have to
                    // register the Broadcast Receiver to listen for Play Store Install information
                    LaunchDeepLinkActivity(Intent);
                }
            }
        }

        protected override void OnStart()
        {
            base.OnStart();

            googleApiClient.Connect();

            RegisterDeepLinkReceiver();
        }

        protected override void OnStop()
        {
            googleApiClient.Disconnect();

            UnregisterDeepLinkReceiver();

            base.OnStop();
        }

        void SendAppInvite()
        {
            var intent = new AppInviteInvitation.IntentBuilder("قم بدعوة اصدقائك!")
                .SetMessage("جرب هذا التطبيق الرائع!")
                .SetDeepLink(Android.Net.Uri.Parse(""))
                .Build();

            StartActivityForResult(intent, REQUEST_INVITE);
        }

        private void Input_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            try
            {
                //input.Enabled = false;

                if (input.Text.Length > start)
                {
                    string tex = input.Text.Replace("ى", "ي").Replace("أ", "ا").Replace("إ", "ا")
                    .Replace("٠", "0").Replace("١", "1").Replace("٢", "2").Replace("٣", "3").Replace("٤", "4").
                        Replace("٥", "5").Replace("٦", "6").Replace("٧", "7").Replace("٨", "8")
                        .Replace("٩", "9").Replace("@ ", "@");
                    ayayt = quran.find(tex, count, extra);

                    if (ayayt.Count > 0)
                    {

                        //     ArrayAdapter adpt = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, ayayt);
                        lv.Adapter = new HomeScreenAdapter(this, ayayt);
                        //  tv.Text = lv.Count.ToString();
                        switch (lv.Count)
                        {
                            case 1:
                                tv.Text = "آَيَة واحدة";
                                break;
                            case 2:
                                tv.Text = "ايتان";
                                break;
                            case 3:
                                tv.Text = lv.Count.ToString() + " آَيَات ";
                                break;
                            case 4:
                                tv.Text = lv.Count.ToString() + " آَيَات ";
                                break;
                            case 5:
                                tv.Text = lv.Count.ToString() + " آَيَات ";
                                break;
                            case 6:
                                tv.Text = lv.Count.ToString() + " آَيَات ";
                                break;
                            case 7:
                                tv.Text = lv.Count.ToString() + " آَيَات ";
                                break;
                            case 8:
                                tv.Text = lv.Count.ToString() + " آَيَات ";
                                break;
                            case 9:
                                tv.Text = lv.Count.ToString() + " آَيَات ";
                                break;
                            case 10:
                                tv.Text = lv.Count.ToString() + " آَيَات ";
                                break;
                            default:
                                tv.Text = lv.Count.ToString() + " آَيَة ";
                                break;
                        }
                    }
                    else
                    {
                        List<string> nul = new List<string>() { "لا توجد آَيَة مطابقة ! " };
                        ArrayAdapter adpt = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItemActivated1
                          , nul);
                        lv.Adapter = adpt;
                        tv.Text = "0 آَيَة";
                    }
                }
                else
                {
                    List<string> nul = new List<string>() { "" };
                    ArrayAdapter adpt = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1
                      , nul);
                    lv.Adapter = adpt;
                    tv.Text = "0 آَيَة";
                }

            }
            catch (Exception ex)
            {
                string st = ex.Message;
                //throw;
            }

            //  input.RequestFocus();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu1, menu);
            // MenuInflater.Inflate(Android.Resource.Menu.)
            return base.OnCreateOptionsMenu(menu);
        }

        //select from menu
        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            switch (item.ItemId)
            {
                case Resource.Id.help:
                    var intent = new Intent(this, typeof(SettingActivity));
                    StartActivity(intent);
                    this.OverridePendingTransition(Android.Resource.Animation.SlideOutRight, Android.Resource.Animation.SlideInLeft);
                    break;

                case Resource.Id.share:
                  //  SendInvite();
                    SendAppInvite();
                    break;

                case Resource.Id.aya:
                    var intent2 = new Intent(this, typeof(aya));
                    StartActivity(intent2);
                    break;

            }
            return base.OnOptionsItemSelected(item);
        }

        protected override void OnResume()
        {
            base.OnResume();
            start = setting.GetInt("start", 0);
            count = setting.GetInt("count", 300);
            extra = setting.GetInt("extra", 1);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            Log.Debug(TAG, "onActivityResult: requestCode=" + requestCode + ", resultCode=" + resultCode);

            if (requestCode == REQUEST_INVITE)
            {
                if (resultCode == Result.Ok)
                {
                    // Check how many invitations were sent and log a message
                    // The ids array contains the unique invitation ids for each invitation sent
                    // (one for each contact select by the user). You can use these for analytics
                    // as the ID will be consistent on the sending and receiving devices.
                    var ids = AppInviteInvitation.GetInvitationIds((int)resultCode, data);

                    Log.Debug(TAG, string.Format("You Sent {0} App Invitations!", ids.Length));
                }
                else
                {
                    // Sending failed or it was canceled, show failure message to the user
                    Toast.MakeText(this, "Failed to send App Invitations :(", ToastLength.Short).Show();
                }
            }
            else if (requestCode == RESOLUTION_CODE)
            {
                if (resultCode == Result.Ok)
                    googleApiClient.Connect();
                else
                    Toast.MakeText(this, "Failed to Connect to Google Play Services", ToastLength.Long).Show();
            }
        }

        void LaunchDeepLinkActivity(Intent intent)
        {
            Log.Debug(TAG, "launchDeepLinkActivity:" + intent);
            //var newIntent = new Intent(intent).SetClass(this, typeof(DeepLinkActivity));
            //StartActivity(newIntent);
        }

        void RegisterDeepLinkReceiver()
        {
            // Create local Broadcast receiver that starts DeepLinkActivity when a deep link
            // is found
            deepLinkReceiver = new LocalBroadcastReceiver
            {
                OnReceiveHandler = (context, intent) => {
                    if (AppInviteReferral.HasReferral(intent))
                        LaunchDeepLinkActivity(intent);
                }
            };

            var intentFilter = new IntentFilter(GetString(Resource.String.action_deep_link));

            LocalBroadcastManager.GetInstance(this).RegisterReceiver(deepLinkReceiver, intentFilter);
        }

        void UnregisterDeepLinkReceiver()
        {
            if (deepLinkReceiver != null)
                LocalBroadcastManager.GetInstance(this).UnregisterReceiver(deepLinkReceiver);
        }

        async Task UpdateInvitationStatus(Intent intent)
        {
            var invitationId = AppInviteReferral.GetInvitationId(intent);

            // Note: these  calls return PendingResult(s), so one could also wait to see
            // if this succeeds instead of using fire-and-forget, as is shown here
            if (AppInviteReferral.IsOpenedFromPlayStore(intent))
                await AppInviteClass.AppInviteApi.UpdateInvitationOnInstallAsync(googleApiClient, invitationId);

            // If your invitation contains deep link information such as a coupon code, you may
            // want to wait to call `convertInvitation` until the time when the user actually
            // uses the deep link data, rather than immediately upon receipt
            await AppInviteClass.AppInviteApi.ConvertInvitationAsync(googleApiClient, invitationId);
        }
    }

    // class list adapter
    public class HomeScreenAdapter : BaseAdapter<string>
    {
        List<string> items;
        Activity context;
        public HomeScreenAdapter(Activity context, List<string> items)
            : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override string this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Count; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = context.LayoutInflater.Inflate(Resource.Layout.mylist, null);
            view.FindViewById<TextView>(Resource.Id.Textv2).Text = item;
            //  view.FindViewById<TextView>(Resource.Id.Text2).Text = item.SubHeading;
            //  view.FindViewById<ImageView>(Resource.Id.Image).SetImageResource(item.ImageResourceId);
            return view;
        }
    }

    // app invit
    class LocalBroadcastReceiver : BroadcastReceiver
    {
        public Action<Context, Intent> OnReceiveHandler { get; set; }

        public override void OnReceive(Context context, Intent intent)
        {
            var h = OnReceiveHandler;
            if (h != null)
                h(context, intent);
        }
    }
}

