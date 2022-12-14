using Microsoft.VisualStudio.TestTools.UnitTesting;
using JPGRawFotoSelector;
namespace MTestJPGAndRawFotoSelector
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void canGetSettings()
        {
            var file = @".\JPGAndRawFotoSelector.xml";
            var settings = JPGRawFotoSelectorSettings.GetSettings(file);
            Assert.IsNotNull(settings);
            Assert.AreEqual(2,settings.Cameras.Length);
        }

        [TestMethod]
        public void testEXIFManager()
        {
            var exif = new ExifManager(@".\DSC04550.JPG");
            Assert.IsNotNull(exif);
            exif.Dispose();
        }
    }
}
