
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Preferences;

namespace Qurany
{
    [Activity(Label = "اية",Icon = "@drawable/s_launcher")]
    public class aya : Activity
    {
        Quran quran = new Quran();
        //setting
        ISharedPreferences setting;

        EditText serch;
        int start;
        int index = 0;
        TextView befor, ayaa, after;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.aya);
            setting = PreferenceManager.GetDefaultSharedPreferences(this);
            serch = FindViewById<EditText>(Resource.Id.editTextSearch);
            befor = FindViewById<TextView>(Resource.Id.textViewBefor);
            ayaa = FindViewById<TextView>(Resource.Id.textViewAya);
            after = FindViewById<TextView>(Resource.Id.textViewAfter);

            //button
            Button nexT = FindViewById<Button>(Resource.Id.button1next);
            nexT.Click += delegate {
                if (serch.Text.Length > start)
                {
                    int oldIndex = index ;
                    string tex = serch.Text.Replace("ى", "ي").Replace("أ", "ا").Replace("إ", "ا")
                       .Replace("٠", "0").Replace("١", "1").Replace("٢", "2").Replace("٣", "3").Replace("٤", "4").
                           Replace("٥", "5").Replace("٦", "6").Replace("٧", "7").Replace("٨", "8")
                           .Replace("٩", "9").Replace("@ ", "@");
                    index = quran.findindex(tex, oldIndex);

                    if (index > 0)
                    {
                        befor.Text = quran[index - 1];
                    }
                    else
                    {
                        befor.Text = "---";
                    }


                    if (index != -1 )
                    {
                        if (index != 6235)
                        {
                            ayaa.Text = quran[index];
                            after.Text = quran[index + 1];
                        }
                        else
                        {
                            ayaa.Text = quran[index];
                            after.Text = "---";
                        }
                       
                    }
                    else
                    {
                        befor.Text = "---";
                        ayaa.Text = "لا توجد اية اخرى مطابقة";
                        after.Text = "---";
                        index = 1;
                    }


                }
                else
                {
                    serch.Hint = "اكتب كلمة البحث هنا اولاً";
                    Toast.MakeText(this, "قم بكتابة كلمة البحث اولاً", ToastLength.Long).Show();
                }
            };

            start = setting.GetInt("start", 0);
            serch.TextChanged += Serch_TextChanged;

            //test 
           // befor.Text = quran.ayat.Length.ToString();
            //ayaa.Text = quran._ayat.Length.ToString();

            // handel befor
            befor.Click += delegate {
                if (index > 0)
                {
                    index--;
                    ayaa.Text = quran[index];
                    
                    after.Text = quran[index + 1];
                    if (index != 0)
                    {
                        befor.Text = quran[index - 1];
                    }
                    else
                    {
                        befor.Text = "---";
                    }
                }
            };

            // handel after
            after.Click += delegate {
                if (index < 6235)
                {
                    index++;
                    ayaa.Text = quran[index];
                    befor.Text = quran[index - 1];
                    if (index != 6235)
                    {
                        after.Text = quran[index + 1];
                    }
                    else
                    {
                        after.Text = "صدق الله العظيم";
                    }

                }
            };
        }

        private void Serch_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            if (serch.Text.Length>start)
            {
                string tex = serch.Text.Replace("ى", "ي").Replace("أ", "ا").Replace("إ", "ا")
                   .Replace("٠", "0").Replace("١", "1").Replace("٢", "2").Replace("٣", "3").Replace("٤", "4").
                       Replace("٥", "5").Replace("٦", "6").Replace("٧", "7").Replace("٨", "8")
                       .Replace("٩", "9").Replace("@ ", "@");
                index = quran.findindex(tex);

                if (index > 0)
                {
                    befor.Text = quran[index - 1];
                }
                else
                {
                    befor.Text = "---";
                }

                
                if (index != -1)
                {
                    ayaa.Text = quran[index];
                    after.Text = quran[index + 1];
                }
                else
                {
                    befor.Text = "---";
                    ayaa.Text = "لا توجد اية مطابقة";
                    after.Text = "---";
                    index = 1;
                }

                
            }
            else
            {
                befor.Text = "ما قبلها";
                ayaa.Text = "الاية";
                after.Text = "ما بعدها";
            }
        }
    }
}