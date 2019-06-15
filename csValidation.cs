using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_FinalProject
{
    class csValidation
    {
        public void TextBoxes(GroupBox grp, string Action)
        {//manages all textboxes, masked  and rick textboxes on the form
            foreach (Control control in grp.Controls)
                if (control is TextBox)
                {
                    if (Action == "Clear")
                    {
                        (control as TextBox).Clear();
                    }
                    else if (Action == "Hide")
                    {
                        (control as TextBox).Hide();
                    }
                    else if (Action == "Enabled")
                    {
                        (control as TextBox).Enabled = true;
                    }
                    else if (Action == "Disabled")
                    {
                        (control as TextBox).Enabled = false;
                    }
                }
        }


        public byte[] ConvertImageToBinary(Image img)
        {//converst images to bynary
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConvertBinaryToImage(byte[] data)
        {//converts binary to an image 
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        public int EmptyTxt(GroupBox grpTxt,ErrorProvider errProviderEdit)
        {//validates all textboxes to have content
            int invalCount = 0;
            foreach (Control control in grpTxt.Controls)
            {//loops for each control on the group box
                if (control is TextBox)
                {//if the control is a textbox this runs
                    if ((control as TextBox).Text == "")
                    {//if control is empty the error provider is called
                        errProviderEdit.SetError(control, "Fill The textbox");
                        invalCount++;
                    }
                    else
                    {//else erros provider is tuened off
                        errProviderEdit.SetError(control, "");
                    }
                }

            }
            return invalCount;
        }//end of function



    }
}
