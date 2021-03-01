using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicrowaveApp.UnitTests
{
    [TestClass]
    public class ImageGeneratorTests
    {
        [TestMethod]
        public void TestCombineBitmapNoFiles()
        {
            List<string> images = new List<string>();
            Bitmap result = ImageGenerator.CombineBitmap(images);
            // Check if size is 500 x 500 and random picked pixels are empty
            Assert.IsTrue(
                result.Size.Height == 500 &&
                result.Size.Width == 500 &&
                result.GetPixel(1, 1).ToArgb() == 0 &&
                result.GetPixel(52, 52).ToArgb() == 0 &&
                result.GetPixel(82, 82).ToArgb() == 0 &&
                result.GetPixel(98, 98).ToArgb() == 0 &&
                result.GetPixel(254, 254).ToArgb() == 0 &&
                result.GetPixel(421, 421).ToArgb() == 0 &&
                result.GetPixel(499, 499).ToArgb() == 0
            );
        }

        [TestMethod]
        public void TestCombineBitmapOneFile()
        {
            List<string> images = new List<string> {"images/Microwave.jpg"};
            Bitmap result = ImageGenerator.CombineBitmap(images);
            Bitmap expectedImage = new Bitmap("TestImages/Microwave.jpg");
            Assert.IsTrue(CompareBitmaps(result, expectedImage));
        }

        [TestMethod]
        public void TestCombineBitmapMultipleFiles()
        {
            List<string> images = new List<string> {"TestImages/MicrowaveOpen.jpg", "TestImages/LampOn.png"};
            Bitmap result = ImageGenerator.CombineBitmap(images);
            Bitmap expectedImage = new Bitmap("TestImages/DoorOpenWithLampOn.png");
            Assert.IsTrue(CompareBitmaps(result, expectedImage));
        }

        public bool CompareBitmaps(Bitmap bitmap, Bitmap bitmap2)
        {
            bool equals = true;
            bool flag = true; //Inner loop isn't broken

            //Test to see if we have the same size of image
            if (bitmap.Size == bitmap2.Size)
            {
                for (int x = 0; x < bitmap.Width; ++x)
                {
                    for (int y = 0; y < bitmap.Height; ++y)
                    {
                        if (bitmap.GetPixel(x, y) != bitmap2.GetPixel(x, y))
                        {
                            equals = false;
                            flag = false;
                            break;
                        }
                    }

                    if (!flag)
                    {
                        break;
                    }
                }
            }
            else
            {
                equals = false;
            }

            return equals;
        }
    }
}