﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Domen
{
    public class GlavniMeniDizajn : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.FromArgb(102, 0, 51);
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.FromArgb(102, 0, 51);
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.FromArgb(102, 0, 51);
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.FromArgb(102, 0, 51);
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.White;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Color.FromArgb(102, 0, 51);
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.FromArgb(102, 0, 51);
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.FromArgb(102, 0, 51);
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.FromArgb(102, 0, 51);
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.FromArgb(102, 0, 51);
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.FromArgb(102, 0, 51);
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.FromArgb(102, 0, 51);
            }
        }
    }
}
