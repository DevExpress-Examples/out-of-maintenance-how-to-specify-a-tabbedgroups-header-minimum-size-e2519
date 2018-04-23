using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Export;
using DevExpress.XtraTab.Registrator;
using DevExpress.LookAndFeel;

namespace WindowsApplication1
{
    [System.ComponentModel.DesignerCategory("")]
    public class MyPageMinSizeHelper : Component
    {

        public static Size PageMinimumSize = new Size(200, 50);

        public Size PageMinSize
        {
            get { return PageMinimumSize; }
            set
            {
                if (PageMinimumSize != value)
                    PageMinimumSize = value;
                LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            }
        }

        public MyPageMinSizeHelper()
        {
            DevExpress.XtraTab.Registrator.PaintStyleCollection.DefaultPaintStyles.Remove("Skin");
            DevExpress.XtraTab.Registrator.PaintStyleCollection.DefaultPaintStyles.Add(new MySkinViewInfoRegistrator());
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }
    }
}
