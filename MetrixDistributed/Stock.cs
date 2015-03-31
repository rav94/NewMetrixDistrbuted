using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixDistributed
{
    class Stock
    {
        private int id;
        private int proid;
        private int instock;
        private int relevel;
        private int requan;
        private int orderer;
        private int proidInvo;
        private int quantityInvo;
        private int balance;

        public int proInvo
        {
            get
            {
                return this.proidInvo;
            }
            set
            {
                proidInvo = value;
            }
        }

        public int quanInvo
        {
            get
            {
                return this.quantityInvo;
            }
            set
            {
                quantityInvo = value;
            }
        }

        public int sid
        {
            get
            {
                return this.id;
            }
            set
            {
                id = value;
            }
        }
        public int SproId
        {
            get
            {
                return this.proid;
            }
            set
            {
                proid = value;
            }
        }
        public int Sinstock
        {
            get
            {
                return this.instock;
            }
            set
            {
                instock = value;
            }
        }
        public int Srelevel
        {
            get
            {
                return this.relevel;
            }
            set
            {
                relevel = value;
            }
        }
        public int Squan
        {
            get
            {
                return this.requan;
            }
            set
            {
                requan = value;
            }
        }
        public int Sordered
        {
            get
            {
                return this.orderer;
            }
            set
            {
                orderer = value;
            }
        }
    }
}
