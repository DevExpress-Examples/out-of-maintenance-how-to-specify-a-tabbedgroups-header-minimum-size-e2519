using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Export;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.ViewInfo;

namespace WindowsApplication1
{
    public class MySkinViewInfoRegistrator : SkinViewInfoRegistrator
    {

        public MySkinViewInfoRegistrator()
        {

        }

        public override DevExpress.XtraTab.ViewInfo.BaseTabHeaderViewInfo CreateHeaderViewInfo(DevExpress.XtraTab.ViewInfo.BaseTabControlViewInfo viewInfo)
        {
            return new MySkinTabHeaderViewInfo(viewInfo);
        }

        
        
    }
}