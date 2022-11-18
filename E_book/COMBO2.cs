using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_book
{
    public partial class COMBO2 : Component
    {
        public COMBO2()
        {
            InitializeComponent();
        }

        public COMBO2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
