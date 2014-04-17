using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Window
    {
        public Window[] m_ChildWindow = new Window[5];
        public bool IsHaveChild = false;
        public bool IsActive;

        public Window GetActiveWindow()
        {
            if (IsHaveChild==false)
            {
                IsActive = true;
                return this;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (m_ChildWindow[i].IsActive==true)
                    {
                        return m_ChildWindow[i];
                    }
                }
            }
            return this;
            
        }
        
    }
}
