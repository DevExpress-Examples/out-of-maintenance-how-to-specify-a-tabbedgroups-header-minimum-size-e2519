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
    public class MySkinTabHeaderViewInfo : SkinTabHeaderViewInfo
    {
        public MySkinTabHeaderViewInfo(BaseTabControlViewInfo viewInfo)
            : base(viewInfo)
        {

        }
        public override Size CalcMinPageSize(BaseTabPageViewInfo info)
        {
            return MyPageMinSizeHelper.PageMinimumSize;
        }
    }
}
