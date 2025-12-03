using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.CaptchaMakers
{
    public interface ICaptchaMaker
    {
        public string MakeCaptcha(PictureBox pictureBox, Random random);
    }
}
