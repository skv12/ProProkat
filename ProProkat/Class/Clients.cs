using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProProkat
{
    /***********************************************************************
 * Module:  clients.cs
 * Author:  Student
 * Purpose: Definition of the Class clients
 ***********************************************************************/


    public class Clients
    {
        public System.Collections.ArrayList orders;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetOrders()
        {
            if (orders == null)
                orders = new System.Collections.ArrayList();
            return orders;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetOrders(System.Collections.ArrayList newOrders)
        {
            RemoveAllOrders();
            foreach (orders oorders in newOrders)
                AddOrders(oorders);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddOrders(orders newOrders)
        {
            if (newOrders == null)
                return;
            if (this.orders == null)
                this.orders = new System.Collections.ArrayList();
            if (!this.orders.Contains(newOrders))
                this.orders.Add(newOrders);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveOrders(orders oldOrders)
        {
            if (oldOrders == null)
                return;
            if (this.orders != null)
                if (this.orders.Contains(oldOrders))
                    this.orders.Remove(oldOrders);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllOrders()
        {
            if (orders != null)
                orders.Clear();
        }

        private String fullname;
        private String address;
        private String contact;
        private String deposit;
        private String regulardebtor;
        private bool blackliststatus;

    }
}
