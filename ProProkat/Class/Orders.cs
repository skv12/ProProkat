using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProProkat
{
    /***********************************************************************
 * Module:  orders.cs
 * Author:  B
 * Purpose: Definition of the Class orders
 ***********************************************************************/


    public class orders 
    {
        public System.Collections.ArrayList cD;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetCD()
        {
            if (cD == null)
                cD = new System.Collections.ArrayList();
            return cD;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetCD(System.Collections.ArrayList newCD)
        {
            RemoveAllCD();
            foreach (CD oCD in newCD)
                AddCD(oCD);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddCD(CD newCD)
        {
            if (newCD == null)
                return;
            if (this.cD == null)
                this.cD = new System.Collections.ArrayList();
            if (!this.cD.Contains(newCD))
                this.cD.Add(newCD);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveCD(CD oldCD)
        {
            if (oldCD == null)
                return;
            if (this.cD != null)
                if (this.cD.Contains(oldCD))
                    this.cD.Remove(oldCD);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllCD()
        {
            if (cD != null)
                cD.Clear();
        }

        private bool status { get; set; }
        private DateTime date { get; set; }
        private String client { get; set; }
        private String disklist { get; set; }
        private DateTime rent { get; set; }
        private String deposit { get; set; }

    }
}
