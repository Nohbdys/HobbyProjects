using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace CycleProject
{

    public partial class Form1 : Form
    {
        #region Private Vars
        int count, minimumGifTime = 5;
        float customTimer = 0.5f;
        string[] imagesSorted;
        Timer cycleTimer;
        string currentFolder;
        bool doOnce = true;
        bool flipSwitch = true;

        //Randomize vars
        string tmpString;
        string[] imagesRandom;
        #endregion

        #region publicVars
        #endregion
        String imagePath = "";
        public Form1()
        {
            InitializeComponent();
            currentFolder = AppDomain.CurrentDomain.BaseDirectory + "images";
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "images"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "images");
            }

            //Sorted array
            imagesSorted = Directory.GetFiles(currentFolder, "*", SearchOption.AllDirectories);
            Array.Sort(imagesSorted);

            //Random array
            imagesRandom = Directory.GetFiles(currentFolder, "*", SearchOption.AllDirectories);
            Shuffle();

            cycleTimer = new Timer();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


            textBoxMinGifTime.Text = minimumGifTime.ToString();
            textBoxDelay.Text = customTimer.ToString();
            textBoxFolderName.Text = currentFolder;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            NextImage();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            PreviousImage();
        }


        /// <summary>
        /// Activates Timer that cycles through images on an interval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCycle_Click(object sender, EventArgs e)
        {
            if (doOnce)
            {
                cycleTimer.Tick += new EventHandler(NextImage);
                doOnce = false;
            }

            //Timer in seconds
            if (textBoxDelay.Text != "")
            {
                customTimer = float.Parse(textBoxDelay.Text, CultureInfo.InvariantCulture);
            }

            if (cycleTimer.Enabled)
            {
                cycleTimer.Stop();
                labelCycle.Text = "Not Cycling";
            }
            else
            {
                cycleTimer.Interval = (int)(customTimer * 1000f);
                cycleTimer.Start();
                labelCycle.Text = "Cycling";
            }
        }

        //Update folder based on input
        private void buttonFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    imagesSorted = Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories);

                    //Random array
                    imagesRandom = Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories);
                    Shuffle();

                    MessageBox.Show("Files found: " + imagesSorted.Length.ToString(), "Message");
                    fbd.Dispose();
                }

            }
        }

        #region Timer Events
        void NextImage(object sender, EventArgs e)
        {
            string path = "";

            if (ExtensionValidator(ref path, "next"))
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }
                pictureBox1.Image = Image.FromFile(path);
            }



            if (path.EndsWith(".gif"))
            {
                pictureBox1.Hide();

                //Runs once
                if (webBrowser1.Controls.Count <= 0)
                {
                    webBrowser1.Show();
                    webBrowser2.Show();
                    webBrowser1.Navigate(path);
                }

                //Gif time check
                TimeSpan tmp2 = (TimeSpan)GifExtension.GetGifDuration(Image.FromFile(path), 60);
                if (tmp2.TotalSeconds * 2 + customTimer < minimumGifTime * 1000)
                {
                    cycleTimer.Interval = minimumGifTime * 1000;
                }
                else
                {
                    cycleTimer.Interval = (int)(customTimer + tmp2.TotalMilliseconds * 2);
                }


                FlipBrowser(path);

                MemoryLeakFix();
            }
            else
            {
                webBrowser1.Hide();
                webBrowser2.Hide();

                pictureBox1.Show();
                cycleTimer.Interval = (int)(customTimer * 1000f);
            }
        }
        #endregion

        //Switch between my 2 active browsers to lower load time. 
        //TODO: Find better way to handle load times
        void FlipBrowser(string path)
        {
            flipSwitch = !flipSwitch;

            if (flipSwitch)
            {
                webBrowser1.BringToFront();
                if (webBrowser2.Controls.Count > 0)
                {
                    webBrowser2.Dispose();
                }
                webBrowser2.Navigate(path);
            }
            else
            {
                webBrowser2.BringToFront();
                if (webBrowser1.Controls.Count > 0)
                {
                    webBrowser1.Dispose();
                }
                webBrowser1.Navigate(path);
            }
        }

        private void NextImage()
        {
            string path = "";


            //Reset timer so we dont skip by accident
            if (cycleTimer.Enabled)
            {
                cycleTimer.Stop();
                cycleTimer.Start();
            }

            if (ExtensionValidator(ref path, "next"))
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }

                pictureBox1.Image = Image.FromFile(path);
            }
            else
            {
                NextImage();
            }

            if (path.EndsWith(".gif"))
            {
                TimeSpan tmp2 = (TimeSpan)GifExtension.GetGifDuration(Image.FromFile(path), 60);

                if (tmp2.TotalSeconds * 2 + customTimer < minimumGifTime * 1000)
                {
                    cycleTimer.Interval = minimumGifTime * 1000;
                }
                else
                {
                    cycleTimer.Interval = (int)(customTimer + tmp2.TotalMilliseconds * 2);
                }

                if (webBrowser1.Controls.Count > 0)
                {
                    webBrowser1.Dispose();
                }

                webBrowser1.Show();
                pictureBox1.Hide();
                webBrowser1.Navigate(path);


                MemoryLeakFix();
            }
            else
            {
                webBrowser1.Hide();
                pictureBox1.Show();
                cycleTimer.Interval = (int)(customTimer * 1000f);
            }
        }

        // straight and not very scalable code.
        void PreviousImage()
        {
            string path = "";

            if (ExtensionValidator(ref path, "previous"))
            {
                pictureBox1.Image = Image.FromFile(path);
            }
            else
            {
                NextImage();
            }

            if (path.Contains(".gif"))
            {
                TimeSpan tmp2 = (TimeSpan)GifExtension.GetGifDuration(Image.FromFile(path), 60);
                cycleTimer.Interval = (int)(customTimer + tmp2.TotalMilliseconds * 2);

                webBrowser1.Show();
                pictureBox1.Hide();

                webBrowser1.Navigate(path);

                MemoryLeakFix();
            }
            else
            {
                webBrowser1.Hide();
                pictureBox1.Show();
                cycleTimer.Interval = (int)(customTimer * 1000f);
            }
        }

        /// <summary>
        /// Shuffles imagesRandom
        /// </summary>
        public void Shuffle()
        {
            for (int j = 0; j < 25; j++)
            {
                for (int i = 0; i < imagesRandom.Length - 1; i++)
                {
                    Random rnd = new Random();

                    int rndInt = rnd.Next(i, imagesRandom.Length);
                    tmpString = imagesRandom[rndInt];
                    imagesRandom[rndInt] = imagesRandom[i];
                    imagesRandom[i] = tmpString;
                }
            }
        }

        //Could split into more functions to increase readability
        bool ExtensionValidator(ref string path, string direction)
        {
            if (direction.Contains("next"))
            {
                if (checkBoxRandom.Checked) // Use Random
                {
                    if (count < imagesRandom.Length - 1)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                    path = imagesRandom[count];
                }
                else // Do not use Random
                {
                    if (count < imagesSorted.Length - 1)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                    path = imagesSorted[count];
                }
            }
            else
            {
                if (checkBoxRandom.Checked) // Use Random
                {
                    if (count > 0)
                    {
                        count--;
                    }
                    else
                    {
                        count = imagesRandom.Length - 1;
                    }
                    path = imagesRandom[count];
                }
                else // Do not use Random
                {
                    if (count > 0)
                    {
                        count--;
                    }
                    else
                    {
                        count = imagesSorted.Length - 1;
                    }
                    path = imagesSorted[count];
                }
            }

            if (!ValidatePath(path))
            {
                ExtensionValidator(ref path, direction);
            }

            return true;
        }

        //Validate wether the file is the specific format we're looking for
        bool ValidatePath(string path)
        {
            if (path.EndsWith(".gif") || path.EndsWith(".png") || path.EndsWith(".jpg") || path.EndsWith(".jpeg"))
            {
                labelNext.Text = (count + 1).ToString();
                labelPrevious.Text = (count - 1).ToString();
                return true;
            }
            return false;
        }


        private void textBoxMinGifTime_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMinGifTime.Text.Any(x => !char.IsLetter(x)))
            {
                minimumGifTime = Convert.ToInt32(textBoxMinGifTime.Text);
            }

        }


        // Double browser to get around slow loading gifs 
        // TODO: Think of better solution
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Body.SetAttribute("scroll", "no");
            var img = webBrowser1.Document.GetElementsByTagName("img")
                         .Cast<HtmlElement>().FirstOrDefault();
            var w = img.ClientRectangle.Width;
            var h = img.ClientRectangle.Height;
            img.Style = string.Format("{0}: 100%", w > h ? "Width" : "Height");
        }
        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser2.Document.Body.SetAttribute("scroll", "no");
            var img = webBrowser2.Document.GetElementsByTagName("img")
                         .Cast<HtmlElement>().FirstOrDefault();
            var w = img.ClientRectangle.Width;
            var h = img.ClientRectangle.Height;
            img.Style = string.Format("{0}: 100%", w > h ? "Width" : "Height");
        }



        private void buttonUseFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxFolderName.Text))
            {
                imagesSorted = Directory.GetFiles(textBoxFolderName.Text, "*", SearchOption.AllDirectories);

                //Random array
                imagesRandom = Directory.GetFiles(textBoxFolderName.Text, "*", SearchOption.AllDirectories);
                Shuffle();

                MessageBox.Show("Files found: " + imagesSorted.Length.ToString(), "Message");
            }
            else
            {
                MessageBox.Show("Invalid Directory", "Message");
            }
        }


        //Anti Memory leak (Browser is a b-word)
        void MemoryLeakFix()
        {
            System.Diagnostics.Process loProcess = System.Diagnostics.Process.GetCurrentProcess();
            try
            {
                loProcess.MaxWorkingSet = (IntPtr)((int)loProcess.MaxWorkingSet - 1);
                loProcess.MinWorkingSet = (IntPtr)((int)loProcess.MinWorkingSet - 1);
            }
            catch (System.Exception)
            {

                loProcess.MaxWorkingSet = (IntPtr)((int)1413120);
                loProcess.MinWorkingSet = (IntPtr)((int)204800);
            }
        }
    }


}

