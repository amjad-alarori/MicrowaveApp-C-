using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MicrowaveApp
{
    public class ImageGenerator
    {
        private readonly PictureBox _pictureBox;
        private string _microwaveImage = "images/Microwave.jpg";
        private string _foodImage = "FoodElements/Img/Burger.png";
        private string _lampImage = "images/LampOff.png";

        public string MicrowaveImage
        {
            set
            {
                _microwaveImage = value;
                GenerateAndSetImage();
            }
        }


        public string FoodImage
        {
            set
            {
                _foodImage = value;
                GenerateAndSetImage();
            }
        }


        public string LampImage
        {
            set
            {
                _lampImage = value;
                GenerateAndSetImage();
            }
        }

        /// <param name="pictureBox">Send pictureBox with construction because we can't access it from within this class</param>
        public ImageGenerator(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
        }

        private void GenerateAndSetImage()
        {
            List<string> files = new List<string> {_microwaveImage, _foodImage, _lampImage};
            _pictureBox.Image = CombineBitmap(files);
        }

        /// <summary>
        /// CombineBitmap is used to combine images, We later use this result in a single PictureBox
        /// Heavily modified from https://stackoverflow.com/a/11472998/13000688
        /// </summary>
        /// <param name="files">List with paths to images</param>
        /// <exception cref="Exception"></exception>
        /// <returns>Single Bitmap with all files combined</returns>
        public static Bitmap CombineBitmap(List<string> files)
        {
            List<Bitmap> images = new List<Bitmap>();
            Bitmap finalImage = new Bitmap(500, 500);

            try
            {
                // Foreach file in files list. Create and add new Bitmap to images list
                files.ForEach(file => images.Add(new Bitmap(file)));

                //get a graphics object from the image so we can draw on it
                using (Graphics graphics = Graphics.FromImage(finalImage))
                {
                    //set background color to transparent
                    graphics.Clear(Color.Transparent);

                    //go through each image and draw it on the final image
                    images.ForEach(bitmap => { graphics.DrawImage(bitmap, 0, 0, 500, 500); });
                }

                return finalImage;
            }
            catch
            {
                // On exception, dispose finalImage to prevent memory issues. And rethrow exception
                finalImage.Dispose();
                throw;
            }
            finally
            {
                // Clean up memory
                images.ForEach(bitmap => bitmap.Dispose());
            }
        }
    }
}