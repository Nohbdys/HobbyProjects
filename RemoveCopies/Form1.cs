using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveCopies
{
    public partial class Form1 : Form
    {

        List<string> imagesSorted = new List<string>();
        List<string> imageDupes = new List<string>();

        private readonly object x = new object();

        Thread thread1;
        bool threadStarted = false;
        int startPoint = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            int tmpNumber = 0;
            foreach (var image in imagesSorted)
            {
                if (image.Contains(".jpg") || image.Contains(".jpeg") || image.Contains(".png") || image.Contains(".jpg") || image.Contains(".gif"))
                {
                    tmpNumber++;

                    int first = 0, second = 0, third = 0, fourth = 0, fifth = 0;

                    first = (tmpNumber % (1 * 10) - (tmpNumber % 1)) / 1;
                    second = (tmpNumber % (10 * 10) - (tmpNumber % 10)) / 10;
                    third = (tmpNumber % (100 * 10) - (tmpNumber % 100)) / 100;
                    fourth = (tmpNumber % (1000 * 10) - (tmpNumber % 1000)) / 1000;
                    fifth = (tmpNumber % (10000 * 10) - (tmpNumber % 10000)) / 10000;

                    string newname = fifth.ToString() + fourth.ToString() + third.ToString() + second.ToString() + first.ToString();
                    if (!File.Exists(textBoxFolder.Text + "/" + newname + ".jpg"))
                    {
                        File.Move(image, textBoxFolder.Text + "/" + newname + ".jpg");
                    }
                }
            }

            GetImages();
        }

        private void buttonGetImages_Click(object sender, EventArgs e)
        {
            GetImages();
        }

        void GetImages()
        {
            if (Directory.Exists(textBoxFolder.Text))
            {
                imagesSorted.Clear();
                imagesSorted.AddRange(Directory.GetFiles(textBoxFolder.Text, "*", SearchOption.TopDirectoryOnly));
                imagesSorted.Sort();
            }
        }

        void FindDuplicates(int range)
        {
            imageDupes.Clear();

            if (textBoxStart.Text != "")
            {
                startPoint = Convert.ToInt32(textBoxStart.Text);
            }

            //Do it twice
            for (int k = 0; k < 2; k++)
            {
                //Image we use
                for (int i = range; i < imagesSorted.Count; i++)
                {
                    //Image we check against
                    for (int j = i + 1; j < imagesSorted.Count; j++)
                    {
                        if (imagesSorted[j].Contains(".jpeg") || imagesSorted[j].Contains(".png") || imagesSorted[j].Contains(".jpg") || imagesSorted[j].Contains(".gif"))
                        {
                            using (var image1 = new Bitmap(imagesSorted[i]))
                            {
                                using (var image2 = new Bitmap(imagesSorted[j]))
                                {
                                    if (image1.Width == image2.Width)
                                    {
                                        if (image1.Height == image2.Height)
                                        {
                                            if (imagesSorted[i] != imagesSorted[j])
                                            {
                                                if (CompareImage(image1, image2))
                                                {
                                                    AddToDupes(j);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    foreach (var image in imageDupes)
                    {
                        if (imagesSorted.Contains(image))
                        {
                            imagesSorted.Remove(image);
                        }
                    }
                }
            }
            threadStarted = false;
        }


        void AddToDupes(int j)
        {
            lock (x)
            {
                imageDupes.Add(imagesSorted[j]);
            }
        }

        public Thread StartTheThread(int range)
        {
            thread1 = new Thread(() => FindDuplicates(range * 100));
            thread1.Start();
            return thread1;
        }


        private void buttonDuplicate_Click(object sender, EventArgs e)
        {
            //Starts a new thread, if it havent been started
            if (!threadStarted)
            {
                for (int i = 0; i < Math.Round((float)(imagesSorted.Count / 100) + 1); i++)
                {
                    threadStarted = true;
                    StartTheThread(i);
                }

            }
            else if (thread1.ThreadState != ThreadState.Suspended)
            {
                thread1.Suspend();
            }
            else
            {
                thread1.Resume();
            }
        }

        bool CompareImage(Image image1, Image image2)
        {
            byte[] image1Bytes;
            byte[] image2Bytes;

            using (var mstream = new MemoryStream())
            {
                image1.Save(mstream, image1.RawFormat);
                image1Bytes = mstream.ToArray();
            }

            using (var mstream = new MemoryStream())
            {
                image2.Save(mstream, image2.RawFormat);
                image2Bytes = mstream.ToArray();
            }

            var image164 = Convert.ToBase64String(image1Bytes);
            var image264 = Convert.ToBase64String(image2Bytes);

            return string.Equals(image164, image264);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (var image in imageDupes)
            {
                File.Delete(image);
            }
        }
    }
}
