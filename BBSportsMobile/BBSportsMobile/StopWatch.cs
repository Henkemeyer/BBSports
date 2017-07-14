using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace BBSportsMobile
{
    public class StopWatch : ContentPage
    {
        StackLayout cookieJar = new StackLayout {Spacing = 25 };
        Stopwatch timer = new Stopwatch();
        Label watch = new Label { Text = "00:00:000", FontSize = 30, HorizontalTextAlignment = TextAlignment.Center };
        Button bStart = new Button { Text = "Start Watch" };
        Button bStop = new Button { Text = "Stop Watch", IsEnabled = false };
        List<long> splits = new List<long>();

        public StopWatch()
        {
            Content = cookieJar;
            cookieJar.Children.Add(watch);
            cookieJar.Children.Add(bStart);
            cookieJar.Children.Add(bStop);

            bStart.Clicked += StartWatch_Clicked;
            bStop.Clicked += StopWatch_Clicked;
        }

        void StartWatch_Clicked(object sender, EventArgs e)
        {
            if (timer.IsRunning)
            {
                int count = 0;
                long splitMille = 0;

                splits.Add(timer.ElapsedMilliseconds);
                count = splits.Count();

                if (count > 1)
                    splitMille = splits[count-1] - splits[count - 2];
                else
                    splitMille = splits[0];

                cookieJar.Children.Add(new Label { Text = splitMille.ToString() });
            }
            else
            {
                timer.Start();
                bStart.Text = "Split";
                bStop.IsEnabled = true;
                TickWatch();
            }
        }

        void TickWatch()
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, 1);

            Device.StartTimer(ts, () => {
                watch.Text = timer.Elapsed.ToString("mm\\:ss\\.fff");

                if (bStop.Text.Equals("Reset"))
                    return false;
                else
                    return true;
            });
        }

        void StopWatch_Clicked(object sender, EventArgs e)
        {
            if (timer.IsRunning)
            {
                timer.Stop();
                bStop.Text = "Reset";
                bStart.IsEnabled = false;
            }
            else
            {
                timer.Reset();
                watch.Text = timer.Elapsed.ToString("mm\\:ss\\.fff");
                bStop.Text = "Stop Watch";
                bStop.IsEnabled = false;
                bStart.Text = "Start Watch";
                bStart.IsEnabled = true;
            }

        }
    }
}